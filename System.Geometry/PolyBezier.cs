using System;
using System.Collections.Generic;
using System.Linq;
using System.DoubleNumerics;
using System.Text;
using System.Collections;

namespace System.Geometry
{
    public class PolyBezier:IReadOnlyList<Bezier>
    {
        public readonly IReadOnlyList<Bezier> Curves;
        public PolyBezier(IEnumerable<Bezier> curves)
        {
            this.Curves = new List<Bezier>(curves);
        }

        public Bezier this[int index] => Curves[index];

        public int Count => Curves.Count;

        public IEnumerator<Bezier> GetEnumerator()
        {
            return Curves.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}