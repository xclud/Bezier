using System;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry.Text
{
    struct Point
    {
        public int X;
        public int Y;
        public PointType Type;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Type = PointType.Line;
        }

        public static PointF operator *(Point lhs, double rhs) => new PointF(new Vector2((double)(lhs.X * rhs), (double)(lhs.Y * rhs)), lhs.Type);

        public static explicit operator Vector2(Point p) => new Vector2(p.X, p.Y);
    }
}