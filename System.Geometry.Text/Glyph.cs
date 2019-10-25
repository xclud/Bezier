using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace System.Geometry.Text
{
    /// <summary>
    /// Represents a single glyph of a font.
    /// </summary>
    public sealed class Glyph
    {
        readonly PointF[] points;
        readonly int[] contours;

        /// <summary>
        /// Bounding box of the Glyph.
        /// </summary>
        public readonly BoundingBox BoundingBox;

        /// <summary>
        /// The leading bearings; this is the offset from the pen at which to position the glyph.
        /// </summary>
        public readonly Vector2 Bearing;

        /// <summary>
        /// The width of the glyph.
        /// </summary>
        public readonly double Width;

        /// <summary>
        /// The height of the glyph.
        /// </summary>
        public readonly double Height;

        /// <summary>
        /// The metrics to use when the glyph is laid out horizontally.
        /// </summary>
        public readonly GlyphMetrics HorizontalMetrics;

        /// <summary>
        /// The metrics to use when the glyph is laid out vertically.
        /// </summary>
        public readonly GlyphMetrics VerticalMetrics;

        internal Glyph(PointF[] points, int[] contours, double linearHorizontalAdvance, double linearVerticalAdvance)
        {
            this.points = points;
            this.contours = contours;

            // find the bounding box
            BoundingBox.Min = new Vector2(double.MaxValue, double.MaxValue);
            BoundingBox.Max = new Vector2(double.MinValue, double.MinValue);

            var pointCount = points.Length - 4;
            for (int i = 0; i < pointCount; i++)
            {
                BoundingBox.Min = Vector2.Min(BoundingBox.Min, points[i].P);
                BoundingBox.Max = Vector2.Max(BoundingBox.Max, points[i].P);
            }

            // save the "pure" size of the glyph, in fractional pixels
            var size = BoundingBox.Max - BoundingBox.Min;
            Width = size.X;
            Height = size.Y;

            Bearing = new Vector2(BoundingBox.Min.X, BoundingBox.Max.Y);

            HorizontalMetrics = new GlyphMetrics(points[pointCount + 1].P.X - points[pointCount].P.X, linearHorizontalAdvance);
            VerticalMetrics = new GlyphMetrics(points[pointCount + 3].P.Y - points[pointCount + 2].P.Y, linearVerticalAdvance);
        }

        /// <summary>
        /// Builds a Path of the current Glyph.
        /// </summary>
        public Path BuildPath(Vector2 offset = default(Vector2))
        {
            // check for an empty outline, which obviously results in an empty render
            if (points.Length <= 0 || contours.Length <= 0)
            {
                return null;
            }

            var path = new Path();

            // walk each contour of the outline and render it
            var firstIndex = 0;
            for (int i = 0; i < contours.Length; i++)
            {
                // decompose the contour into drawing commands
                var lastIndex = contours[i];
                Geometry.DecomposeContour(path, firstIndex, lastIndex, points, offset);

                // next contour starts where this one left off
                firstIndex = lastIndex + 1;
            }

            return path;
        }
    }
}
