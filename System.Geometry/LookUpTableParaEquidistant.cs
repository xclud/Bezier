using System;
using System.Collections;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    /// <summary>LookUp Table of coordinates on the curve, spaced at parametrically equidistance intervals (The t values of the points all have the same distance).</summary>
    /// <seealso cref="System.Geometry.LookupTableBase" />
    public class LookUpTableParaEquidistant : LookupTableBase
    {

        readonly IReadOnlyList<Vector2> LUT;

        /// <summary>
        /// Generates a LookUp Table of coordinates on the curve, spaced at parametrically equidistance intervals (The t values of the points all have the same distance). If steps is given, the LUT will contain steps+1 coordinates representing the coordinates from t=0 to t=1 at interval 1/steps.
        /// If Steps is omitted, a default value of Steps=100 is used.
        /// </summary>
        /// <param name="Bezier">The Bezier curve used to create the lookup table</param>
        /// <param name="Steps">Number of steps/positions in the lookup table</param>
        public LookUpTableParaEquidistant(Bezier Bezier, int Steps = 100) : base(Bezier)
        {
            if (Steps < 1) throw new ArgumentOutOfRangeException(nameof(Steps), Steps, $"The argument {nameof(Steps)} must be >=1");

            List<Vector2> L = new List<Vector2>();
            for (double i = 0; i < Steps; i++)
            {
                double t = i / Steps;
                L.Add(Bezier.Position(t));
            }
            this.LUT = L;
        }



        protected override IReadOnlyList<Vector2> GetLUT()
        {
            return LUT;
        }

        override protected double MapToT(double u)
        {
            return u;
        }




    }
}
