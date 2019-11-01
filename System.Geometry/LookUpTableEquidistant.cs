using System;
using System.Collections;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    /// <summary>
    /// LookUp Table of coordinates on the curve, spaced at equidistant intervals (All points of the LUT have the same distance).
    /// </summary>
    /// <seealso cref="System.Geometry.LookupTableBase" />
    public class LookUpTableEquidistant :LookupTableBase
    {
        private readonly int Steps;
       
        private readonly double[] arcLengths;
        private readonly double length;
        private List<Vector2> _lut = new List<Vector2>();

     
        /// <summary>
        /// Generates a LookUp Table of coordinates on the curve, spaced at equidistant intervals (All points of the LUT have the same distance). 
        /// </summary>
        public LookUpTableEquidistant(Bezier bezier, int steps = 100):base(bezier)
        {
          
            this.Steps = steps;

            var step = 1.0d / steps;


            this.Steps = steps;
            this.arcLengths = new double[this.Steps + 1];
            this.arcLengths[0] = 0;

            var o = Bezier.Position(0);
            var clen = 0.0D;

            for (int i = 1; i <= this.Steps; i++)
            {
                Vector2 xy = bezier.Position(i * step);
                Vector2 d = o - xy;

                clen += d.Length();

                this.arcLengths[i] = clen;
                o = xy;
            }

            this.length = clen;
        }

      override  protected double MapToT(double u)
        {
            var targetLength = u * this.arcLengths[this.Steps];
            var low = 0;
            var high = this.Steps;
            var index = 0;

            while (low < high)
            {
                index = low + (((high - low) / 2) | 0);
                if (this.arcLengths[index] < targetLength)
                {
                    low = index + 1;
                }
                else
                {
                    high = index;
                }
            }
            if (this.arcLengths[index] > targetLength)
            {
                index--;
            }

            var lengthBefore = this.arcLengths[index];
            if (lengthBefore == targetLength)
            {
                return index / (double)this.Steps;

            }
            else
            {
                return (index + (targetLength - lengthBefore) / (this.arcLengths[index + 1] - lengthBefore)) / (double)this.Steps;
            }
        }


       override protected IReadOnlyList<Vector2> GetLUT()
        {
            var steps = Steps;

            if (_lut.Count == steps)
            {
                return _lut;
            }
            _lut = new List<Vector2>();
            // We want a range from 0 to 1 inclusive, so
            // we decrement and then use <= rather than <:
            steps--;
            for (double r = 0; r <= steps; r++)
            {
                _lut.Add(Bezier.Position(MapToT(r / (double)steps)));
            }
            return _lut;
        }



      

    }


}