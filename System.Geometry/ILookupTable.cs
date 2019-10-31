using System.Collections.Generic;
using System.DoubleNumerics;

namespace System.Geometry
{
    public interface ILookupTable: IEnumerable<Vector2>, IReadOnlyList<Vector2>
    {
        Bezier Bezier { get; }

        Vector2 Project(Vector2 point);
        Vector2 Project(Vector2 point, out double t, out double d);
    }
}