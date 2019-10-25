using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    public struct BoundingBox
    {
        public Vector2 Min;
        public Vector2 Max;

        public static readonly BoundingBox Infinity = new BoundingBox(new Vector2(float.PositiveInfinity), new Vector2(float.NegativeInfinity));

        public BoundingBox(Vector2 min, Vector2 max)
        {
            Min = min;
            Max = max;
        }


        /// <summary>
        /// Increase a measurement by an additional measurement.
        /// </summary>
        public static BoundingBox operator +(BoundingBox a, BoundingBox b)
        {
            return new BoundingBox
            {
                Min = Vector2.Min(a.Min, b.Min),
                Max = Vector2.Max(a.Max, b.Max)
            };
        }


        public static BoundingBox operator +(BoundingBox a, Vector2 b)
        {
            return new BoundingBox
            {
                Min = a.Min + b,
                Max = a.Max + b
            };
        }


        public static BoundingBox operator +(Vector2 b, BoundingBox a)
        {
            return new BoundingBox
            {
                Min = a.Min + b,
                Max = a.Max + b
            };
        }


        public static BoundingBox operator -(BoundingBox a, Vector2 b)
        {
            return new BoundingBox
            {
                Min = a.Min - b,
                Max = a.Max - b
            };
        }

        public static BoundingBox operator -(Vector2 b, BoundingBox a)
        {
            return new BoundingBox
            {
                Min = a.Min - b,
                Max = a.Max - b
            };
        }
        public static bool Intersects(BoundingBox b1, BoundingBox b2)
        {
            var lx = (b1.Max.X + b1.Min.X) / 2;
            var tx = (b2.Max.X + b2.Min.X) / 2;
            var dx = ((b1.Max.X - b1.Min.X) + (b2.Max.X - b2.Min.X)) / 2.0f;

            if (Math.Abs(lx - tx) >= dx) return false;

            var ly = (b1.Max.Y + b1.Min.Y) / 2;
            var ty = (b2.Max.Y + b2.Min.Y) / 2;
            var dy = ((b1.Max.Y - b1.Min.Y) + (b2.Max.Y - b2.Min.Y)) / 2.0f;

            if (Math.Abs(ly - ty) >= dy) return false;

            return true;
        }

        internal float Width => Max.X - Min.X;
        internal float Height => Max.Y - Min.Y;
    }
}