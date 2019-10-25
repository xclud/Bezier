using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    internal static class IntersectHelper
    {
        public static Pair<float>[] Intersect(Circle circle1, Circle circle2, int accuracy = 4, bool excludeTangents = false)
        {
            //no-op if either circle is degenerate
            if (circle1.Radius <= 0 || circle2.Radius <= 0)
            {
                return null;
            }

            //see if circles are the same
            if (circle1.Radius == circle2.Radius && Point.IsPointEqual(circle1.Center, circle2.Center, .0001))
            {
                //options.out_AreOverlapped = true;
                return null;
            }

            //get offset from origin
            Vector2 offset = -circle1.Center;

            //clone circle1 and move to origin
            var c1 = new Circle(Vector2.Zero, circle1.Radius);

            //clone circle2 and move relative to circle1
            var c2 = new Circle(circle2.Center - circle1.Center, circle2.Radius);

            //rotate circle2 to horizontal, c2 will be to the right of the origin.
            float c2Angle = Angle.OfPointInDegrees(Vector2.Zero, c2.Center);
            c2.Rotate(-c2Angle, Vector2.Zero);

            float unRotate(float resultAngle)
            {
                float unrotated = resultAngle + c2Angle;
                return Angle.NoRevolutions(unrotated);
            }

            //get X of c2 origin
            float x = c2.Center.X;

            //see if circles are tangent interior on left side
            if (Helper.Round(c2.Radius - x - c1.Radius, accuracy) == 0)
            {
                if (excludeTangents)
                {
                    return null;
                }

                return new[] { new Pair<float>(unRotate(180) / 360.0f, unRotate(180) / 360.0f) };
            }

            //see if circles are tangent interior on right side
            if (Helper.Round(c2.Radius + x - c1.Radius, accuracy) == 0)
            {
                if (excludeTangents)
                {
                    return null;
                }

                return new[] { new Pair<float>(unRotate(0) / 360.0f, unRotate(0) / 360.0f) };
            }

            //see if circles are tangent exterior
            if (Helper.Round(x - c2.Radius - c1.Radius, accuracy) == 0)
            {
                if (excludeTangents)
                {
                    return null;
                }

                return new[] { new Pair<float>(unRotate(0) / 360.0f, unRotate(180) / 360.0f) };
            }

            //see if c2 is outside of c1
            if (Helper.Round(x - c2.Radius, accuracy) > c1.Radius)
            {
                return null;
            }

            //see if c2 is within c1
            if (Helper.Round(x + c2.Radius, accuracy) < c1.Radius)
            {
                return null;
            }

            //see if c1 is within c2
            if (Helper.Round(x - c2.Radius, accuracy) < -c1.Radius)
            {
                return null;
            }

            float c1IntersectionAngle = SolveTriangleSSS(c2.Radius, c1.Radius, x);
            float c2IntersectionAngle = SolveTriangleSSS(c1.Radius, x, c2.Radius);

            var aa1 = unRotate(c1IntersectionAngle) / 360.0f;
            var aa2 = unRotate(Angle.Mirror(c1IntersectionAngle, false, true)) / 360.0f;

            var bb1 = unRotate(180 - c2IntersectionAngle) / 360.0f;
            var bb2 = unRotate(Angle.Mirror(180 - c2IntersectionAngle, false, true)) / 360.0f;

            var a = new Pair<float>(aa1, bb1);
            var b = new Pair<float>(aa2, bb2);

            return new Pair<float>[] { a, b };
        }

        public static Pair<float>[] Intersect(Line line1, Line line2, int accuracy = 4)
        {
            var p1 = line1.P1;
            var p2 = line1.P2;

            var p3 = line2.P1;
            var p4 = line2.P2;

            // Get the segments' parameters.
            var dx12 = p2.X - p1.X;
            var dy12 = p2.Y - p1.Y;
            var dx34 = p4.X - p3.X;
            var dy34 = p4.Y - p3.Y;

            // Solve for t1 and t2
            var denominator = dy12 * dx34 - dx12 * dy34;

            if (denominator == 0)
            {
                // The lines are parallel (or close enough to it).
                return null;
            }

            float t1 = ((p1.X - p3.X) * dy34 + (p3.Y - p1.Y) * dx34) / denominator;
            float t2 = ((p3.X - p1.X) * dy12 + (p1.Y - p3.Y) * dx12) / -denominator;

            if (t1 < 0 || t1 > 1) return null;
            if (t2 < 0 || t2 > 1) return null;

            return new Pair<float>[] { new Pair<float>(t1, t2) };
        }

        public static IEnumerable<Pair<float>> Intersect(Line line, Arc arc, int accuracy = 4, bool excludeTangents = false)
        {
            var ratios = Intersect(line, new Circle(arc.Center, arc.Radius), accuracy, excludeTangents);
            if (ratios != null)
            {
                float[] right = GetRatiosWithinArc(ratios.Select(x => x.Right), arc, excludeTangents);

                if (right != null)
                {
                    return ratios.Zip(right, (l, r) => new Pair<float>(l.Left, r));
                }
            }

            return null;
        }

        public static IEnumerable<Pair<float>> Intersect(Arc arc1, Arc arc2, int accuracy = 4, bool excludeTangents = false)
        {
            var ratios = Intersect(new Circle(arc1.Center, arc1.Radius), new Circle(arc2.Center, arc2.Radius), accuracy, excludeTangents);
            if (ratios != null)
            {
                float[] left = GetRatiosWithinArc(ratios.Select(x => x.Left), arc1, excludeTangents);
                float[] right = GetRatiosWithinArc(ratios.Select(x => x.Right), arc2, excludeTangents);

                if (left != null && right != null)
                {
                    return left.Zip(right, (l, r) => new Pair<float>(l, r));
                }
            }

            return null;
        }

        public static IEnumerable<Pair<float>> Intersect(Arc arc, Circle circle, int accuracy = 4, bool excludeTangents = false)
        {
            var ratios = Intersect(new Circle(arc.Center, arc.Radius), circle, accuracy, excludeTangents);
            if (ratios != null)
            {
                float[] left = GetRatiosWithinArc(ratios.Select(x => x.Left), arc, excludeTangents);

                if (left != null)
                {
                    return left.Zip(ratios, (l, r) => new Pair<float>(l, r.Right));
                }
            }

            return null;
        }


        public static Pair<float>[] Intersect(Line line, Circle circle, int accuracy = 4, bool excludeTangents = false)
        {
            //no-op for degenerate circle
            if (circle.Radius <= 0)
            {
                return null;
            }

            //clone the line
            var clonedLine = new Line(line.P1 - circle.Center, line.P2 - circle.Center);

            //get angle of line
            float lineAngleNormal = Angle.OfLineInDegrees(line);

            //use the positive horizontal angle
            float lineAngle = (lineAngleNormal >= 180) ? lineAngleNormal - 360 : lineAngleNormal;

            //rotate the line to horizontal
            clonedLine.Rotate(-lineAngle, Vector2.Zero);

            //remember how to undo the rotation we just did
            float unRotate(float resultAngle)
            {
                float unrotated = resultAngle + lineAngle;
                return Angle.NoRevolutions(unrotated);
            }

            //line is horizontal, get the y value from any point
            float lineY = clonedLine.P1.Y;
            float lineYabs = Math.Abs(lineY);

            //if y is greater than radius, there is no intersection
            if (lineYabs > circle.Radius)
            {
                return null;
            }

            List<Pair<float>> lineIntersection = new List<Pair<float>>();


            //if horizontal Y is the same as the radius, we know it's 90 degrees
            if (lineYabs == circle.Radius)
            {
                if (excludeTangents)
                {
                    return null;
                }

                var a = unRotate(lineY > 0 ? 90 : 270);
                var x = circle.Radius;
                var t = Math.Abs((x - clonedLine.P2.X) / (clonedLine.P2.X - clonedLine.P1.X));
                lineIntersection.Add(new Pair<float>(t, a / 360.0f));
            }
            else
            {
                void intersectionBetweenEndpoints(float x, float angleOfX)
                {
                    if (Helper.IsBetween(x, clonedLine.P1.X, clonedLine.P2.X, excludeTangents))
                    {
                        var a = unRotate(angleOfX);
                        var t = Math.Abs((x - clonedLine.P1.X) / (clonedLine.P2.X - clonedLine.P1.X));

                        lineIntersection.Add(new Pair<float>(t, a / 360.0f));
                    }
                }

                //find angle where line intersects
                float intersectRadians = (float)Math.Asin(lineY / circle.Radius);
                float intersectDegrees = Angle.ToDegrees(intersectRadians);

                //line may intersect in 2 places
                float intersectX = (float)Math.Cos(intersectRadians) * circle.Radius;
                intersectionBetweenEndpoints(-intersectX, 180 - intersectDegrees);
                intersectionBetweenEndpoints(intersectX, intersectDegrees);
            }

            if (lineIntersection.Count > 0)
            {
                return lineIntersection.ToArray();
            }

            return null;
        }


        /// <summary>
        /// Solves for the angle of a triangle when you know lengths of 3 sides.
        /// </summary>
        /// <param name="lengthA">Length of side of triangle, opposite of the angle you are trying to find.</param>
        /// <param name="lengthB">Length of any other side of the triangle.</param>
        /// <param name="lengthC">Length of the remaining side of the triangle.</param>
        /// <returns>Angle opposite of the side represented by the first parameter.</returns>
        private static float SolveTriangleSSS(float lengthA, float lengthB, float lengthC)
        {
            return Angle.ToDegrees((float)Math.Acos((lengthB * lengthB + lengthC * lengthC - lengthA * lengthA) / (2 * lengthB * lengthC)));
        }


        private static float[] GetRatiosWithinArc(IEnumerable<float> ratios, Arc arc, bool excludeTangents)
        {
            if (ratios == null)
            {
                return null;
            }

            List<float> ratiosWithinArc = new List<float>();
            float startAngle = arc.StartAngle;
            if (startAngle > 180) startAngle = startAngle - 360;
            var span = Angle.OfArcSpan(arc);

            foreach (var ratio in ratios)
            {
                if (Helper.IsBetweenArcAngles(arc, ratio * 360.0f, excludeTangents))
                {
                    var xr = (ratio * 360 - startAngle) / span;

                    if (xr < 0)
                    {
                        xr *= -1;
                    }

                    ratiosWithinArc.Add(xr);
                }
            }

            if (ratiosWithinArc.Count == 0)
            {
                return null;
            }

            return ratiosWithinArc.ToArray();
        }

    }
}