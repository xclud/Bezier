using System;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry.Text
{
    struct PointF
    {
        public Vector2 P;
        public PointType Type;

        public PointF(Vector2 position, PointType type)
        {
            P = position;
            Type = type;
        }

        public PointF Offset(Vector2 offset) => new PointF(P + offset, Type);

        public override string ToString() => $"{P} ({Type})";

        public static implicit operator Vector2(PointF p) => p.P;
    }
}
