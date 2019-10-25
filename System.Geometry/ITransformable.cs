using System;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    internal interface ITransformable
    {
        void Move(Vector2 offset);
        void Rotate(double angleInDegrees, Vector2 rotationOrigin);

    }
}
