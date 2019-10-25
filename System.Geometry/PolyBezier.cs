using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    public class PolyBezier
    {
        public readonly List<Bezier> Curves;
        public PolyBezier(List<Bezier> curves)
        {
            this.Curves = new List<Bezier>(curves);
        }
    }
}