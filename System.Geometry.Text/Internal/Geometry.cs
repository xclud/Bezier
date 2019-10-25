using System;
using System.Collections.Generic;
using System.Numerics;
using System.Geometry;

namespace System.Geometry.Text
{
    enum PointType
    {
        Line,
        Quadratic,
        Cubic
    }

    static class Geometry
    {
        public static void ComposeGlyphs(int glyphIndex, int startPoint, ref Matrix3x2 transform, List<PointF> basePoints, List<int> baseContours, GlyphDescription[] glyphTable)
        {
            var glyph = glyphTable[glyphIndex];
            if (glyph is SimpleGlyphDescription simple)
            {
                foreach (var endpoint in simple.ContourEndpoints)
                {
                    baseContours.Add(endpoint + startPoint);
                }
                foreach (var point in simple.Points)
                {
                    basePoints.Add(new PointF(Vector2.TransformNormal((Vector2)point, transform), point.Type));
                }
            }
            else
            {
                // otherwise, we have a composite glyph
                var composite = (CompositeGlyphDescription)glyph;
                foreach (var subglyph in composite.SubGlyphs)
                {
                    // if we have a scale, update the local transform
                    var local = transform;
                    bool haveScale = (subglyph.Flags & (CompositeGlyphFlags.HaveScale | CompositeGlyphFlags.HaveXYScale | CompositeGlyphFlags.HaveTransform)) != 0;
                    if (haveScale)
                        local = transform * subglyph.Transform;

                    // recursively compose the subglyph into our lists
                    int currentPoints = basePoints.Count;
                    ComposeGlyphs(subglyph.Index, currentPoints, ref local, basePoints, baseContours, glyphTable);

                    // calculate the offset for the subglyph. we have to do offsetting after composing all subglyphs,
                    // because we might need to find the offset based on previously composed points by index
                    Vector2 offset;
                    if ((subglyph.Flags & CompositeGlyphFlags.ArgsAreXYValues) != 0)
                    {
                        offset = new Vector2(subglyph.Arg1, subglyph.Arg2);

                        if (haveScale && (subglyph.Flags & CompositeGlyphFlags.ScaledComponentOffset) != 0)
                        {
                            offset = Vector2.TransformNormal(offset, local);
                        }
                        else
                        {
                            offset = Vector2.TransformNormal(offset, transform);
                        }

                        // if the RoundXYToGrid flag is set, round the offset components
                        if ((subglyph.Flags & CompositeGlyphFlags.RoundXYToGrid) != 0)
                        {
                            offset = new Vector2((double)Math.Round(offset.X), (double)Math.Round(offset.Y));
                        }
                    }
                    else
                    {
                        // if the offsets are not given in FUnits, then they are point indices
                        // in the currently composed base glyph that we should match up
                        var p1 = basePoints[(int)((uint)subglyph.Arg1 + startPoint)];
                        var p2 = basePoints[(int)((uint)subglyph.Arg2 + currentPoints)];
                        offset = p1.P - p2.P;
                    }

                    // translate all child points
                    if (offset != Vector2.Zero)
                    {
                        for (int i = currentPoints; i < basePoints.Count; i++)
                        {
                            basePoints[i] = basePoints[i].Offset(offset);
                        }
                    }
                }
            }
        }

        public static void DecomposeContour(Path path, int firstIndex, int lastIndex, PointF[] points, Vector2 offset = default(Vector2))
        {
            var pointIndex = firstIndex;
            var start = points[pointIndex];
            var end = points[lastIndex];
            var control = start;

            if (start.Type == PointType.Cubic)
            {
                throw new InvalidFontException("Contours can't start with a cubic control point.");
            }

            if (start.Type == PointType.Quadratic)
            {
                // if first point is a control point, try using the last point
                if (end.Type == PointType.Line)
                {
                    start = end;
                    lastIndex--;
                }
                else
                {
                    // if they're both control points, start at the middle
                    start.P = (start.P + end.P) / 2;
                }
                pointIndex--;
            }

            // let's draw this contour
            path.MoveTo(start.P + offset);

            var needClose = true;
            while (pointIndex < lastIndex)
            {
                var point = points[++pointIndex];
                switch (point.Type)
                {
                    case PointType.Line:
                        path.LineTo(point.P + offset);
                        break;

                    case PointType.Quadratic:
                        control = point;
                        var done = false;
                        while (pointIndex < lastIndex)
                        {
                            var next = points[++pointIndex];
                            if (next.Type == PointType.Line)
                            {
                                path.CurveTo(control + offset, next + offset);
                                done = true;
                                break;
                            }

                            if (next.Type != PointType.Quadratic)
                            {
                                throw new InvalidFontException("Bad outline data.");
                            }

                            path.CurveTo(control + offset, ((control.P + next.P) / 2) + offset);
                            control = next;
                        }

                        if (!done)
                        {
                            // if we hit this point, we're ready to close out the contour
                            path.CurveTo(control + offset, start + offset);
                            needClose = false;
                        }
                        break;

                    case PointType.Cubic:
                        {
                            throw new NotSupportedException();
                        }
                }
            }

            if (needClose)
            {
                path.LineTo(start.P + offset);
            }
        }
    }
}