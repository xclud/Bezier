using System;
using System.Collections;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    public class LookUpTable : IEnumerable<Vector2>
    {
        private readonly int Steps;
        private readonly Bezier Bezier;
        private readonly double[] arcLengths;
        private readonly double length;
        private List<Vector2> _lut = new List<Vector2>();

        /// <summary>
        /// Generates a LookUp Table of coordinates on the curve, spaced at parametrically equidistance intervals. If steps is given, the LUT will contain steps coordinates representing the coordinates from t=0 to t=1 at interval 1/steps.
        /// </summary>
        public LookUpTable(Bezier bezier, int steps = 100)
        {
            this.Bezier = bezier;
            this.Steps = steps;

            var step = 1.0d / steps;


            this.Steps = steps;
            this.arcLengths = new double[this.Steps + 1];
            this.arcLengths[0] = 0;

            var o = Bezier.Position(0);
            var clen = 0.0D;

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

        public double Map(double u)
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
                _lut.Add(Bezier.Position(Map(t / (double)steps)));
            }
            return _lut;
        }

        /// <summary>
        /// Finds the on-curve point closest to the specific off-curve point, using a two-pass projection test based on the curve's LUT.
        /// A distance comparison finds the closest match, after which a fine interval around that match is checked to see if a better projection can be found.
        /// </summary>
        public Vector2 Project(Vector2 point, out double t, out double d)
        {
            // step 1: coarse check
            var LUT = GetLUT();
            int l = LUT.Count - 1;
            Utils.Closest(LUT, point, out double mdist, out int mpos);

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
            double step = 0.1d / l;
            mdist += 1;

            t = t1;
            double ft = t;

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

        public IEnumerator<Vector2> GetEnumerator()
        {
            return new LookUpTableEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        internal class LookUpTableEnumerator : IEnumerator<Vector2>
        {
            LookUpTable lookUpTable = null;
            int position = -1;
            public LookUpTableEnumerator(LookUpTable LookUpTable)
            {
                this.lookUpTable = LookUpTable;

            }

            public Vector2 Current
            {
                get
                {
                    try
                    {
                        return lookUpTable.GetLUT()[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                position++;
                return (position < lookUpTable.GetLUT().Count);
            }

            public void Reset()
            {
                position = -1;
            }
        }

    }


}