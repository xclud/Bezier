using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    public class LookUpTable
    {
        private readonly int Steps;
        private readonly Bezier Bezier;
        private readonly float[] arcLengths;
        private readonly float length;
        private List<Vector2> _lut = new List<Vector2>();

        public LookUpTable(Bezier bezier, int steps)
        {
            this.Bezier = bezier;
            this.Steps = steps;

            var step = 1.0f / steps;


            this.Steps = steps;
            this.arcLengths = new float[this.Steps + 1];
            this.arcLengths[0] = 0;

            var o = Bezier.Position(0);
            var clen = 0.0f;

            for (var i = 1; i <= this.Steps; i++)
            {
                var xy = bezier.Position(i * step);
                var d = o - xy;

                clen += d.Length();

                this.arcLengths[i] = clen;
                o = xy;
            }

            this.length = clen;
        }

        public float Map(float u)
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
                return index / (float)this.Steps;

            }
            else
            {
                return (index + (targetLength - lengthBefore) / (this.arcLengths[index + 1] - lengthBefore)) / (float)this.Steps;
            }
        }

        /// <summary>
        /// Generates a LookUp Table of coordinates on the curve, spaced at parametrically equidistance intervals. If steps is given, the LUT will contain steps+1 coordinates representing the coordinates from t=0 to t=1 at interval 1/steps.
        /// </summary>
        /// <param name="steps">Number of steps.</param>
        /// <returns>Returns a list of vectors.</returns>
        private List<Vector2> GetLUT()
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
            for (int t = 0; t <= steps; t++)
            {
                _lut.Add(Bezier.Position(Map(t / (float)steps)));
            }
            return _lut;
        }

        /// <summary>
        /// Finds the on-curve point closest to the specific off-curve point, using a two-pass projection test based on the curve's LUT.
        /// A distance comparison finds the closest match, after which a fine interval around that match is checked to see if a better projection can be found.
        /// </summary>
        public Vector2 Project(Vector2 point, out float t, out float d)
        {
            // step 1: coarse check
            var LUT = GetLUT();
            int l = LUT.Count - 1;
            Utils.Closest(LUT, point, out float mdist, out int mpos);

            if (mpos == 0 || mpos == l)
            {
                t = mpos / l;
                Vector2 pt = Bezier.Position(t);
                d = mdist;
                return pt;
            }

            // step 2: fine check
            int t1 = (mpos - 1) / l;
            int t2 = (mpos + 1) / l;
            float step = 0.1f / l;
            mdist += 1;

            t = t1;
            float ft = t;

            for (; t < t2 + step; t += step)
            {
                Vector2 pp = Bezier.Position(t);
                d = Vector2.Distance(point, pp);
                if (d < mdist)
                {
                    mdist = d;
                    ft = t;
                }
            }
            Vector2 p = Bezier.Position(ft);
            t = ft;
            d = mdist;
            return p;
        }
    }
}