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
            for (double r = 0; r <= steps; r++)
            {
                _lut.Add(Bezier.Position(Map(r / (double)steps)));
            }
            return _lut;
        }



        /// <summary>
        /// Finds the on-curve point closest to the specific off-curve point, using a two-pass projection test based on the curve's LUT.
        /// A distance comparison finds the closest match, after which a fine interval around that match is checked to see if a better projection can be found.
        /// </summary>
        public Vector2 Project(Vector2 point)
        {
            return Project(point, out double t, out double d);
        }

        /// <summary>
        /// Finds the on-curve point closest to the specific off-curve point, using a two-pass projection test based on the curve's LUT.
        /// A distance comparison finds the closest match, after which a fine interval around that match is checked to see if a better projection can be found.
        /// </summary>
        public Vector2 Project(Vector2 point, out double t, out double d)
        {
            // step 1: coarse check
            List<Vector2> LUT = GetLUT();
            int len = LUT.Count - 1;
            Utils.Closest(LUT, point, out double lutDist, out int lutPos);

            //Wrong!
            //This returns the last or the first point even if the are not really the closest poistion on the curve
            //This is also wrong in the org js code of pomax.
            //if (mpos == 0 || mpos == l)
            //{
            //    t = mpos / l;
            //    Vector2 pt = Bezier.Position(t);
            //    d = mdist;
            //    return pt;
            //}

            // step 2: fine check


            //The following part is quite different from the org code by xclud.

            const double refinementSteps = 50;

            double t1 = ((double)lutPos - 1) / len;
            double t2 = ((double)lutPos + 1) / len;
            if (t1 < 0) t1 = 0;
            if (t2 > 1) t2 = 1;
            t1 = Map(t1);
            t2 = Map(t2);
            double step = Math.Abs(t2 - t1) / refinementSteps;
            //mdist += 1;

            double ft = -1;// ((double)lutPos) / len;
            double mdist = double.MaxValue;

            for (int i = 0; i < 2; i++)
            {


                Vector2 pp;
                for (double ct = t1; ct < t2; ct += step)
                {
                    pp = Bezier.Position(ct);
                    d = Vector2.Distance(point, pp);
                    if (d < mdist)
                    {
                        mdist = d;
                        ft = ct;
                    }
                }
                //Just to make sure that t2 is really checked
                pp = Bezier.Position(t2);
                d = Vector2.Distance(point, pp);
                if (d < mdist)
                {
                    mdist = d;
                    ft = t2;
                }
                t1 = ft - step;
                t2 = ft + step;
                step /= refinementSteps;
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