using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    /// <summary>Abstract base class for Bezier lookup tables.</summary>
    /// <seealso cref="System.Collections.Generic.IEnumerable{System.DoubleNumerics.Vector2}" />
    /// <seealso cref="System.Collections.Generic.IReadOnlyList{System.DoubleNumerics.Vector2}" />
    public abstract class LookupTableBase : ILookupTable
    {
        /// <summary>Initializes a new instance of the <see cref="LookupTableBase"/> class.</summary>
        /// <param name="bezier">  The bezier curve on which the lookup table is based.</param>
        /// <exception cref="ArgumentNullException">bezier = null</exception>
        protected LookupTableBase(Bezier bezier)
        {
            this.Bezier = bezier ?? throw new ArgumentNullException(nameof(bezier));
        }

        /// <summary>  The Bezier curve for the lookup table.</summary>
        /// <value>  Bezier curve</value>
        public Bezier Bezier { get; private set; }


        /// <summary>Returns the lookup table for the Bezier curve.<br />Typically this should return a reference to a precalculated list of vectors.<br /></summary>
        /// <returns>List of points on the Bezier curve.</returns>
        protected abstract IReadOnlyList<Vector2> GetLUT();

        /// <summary>Maps the given value to a t value between 0 and 1.</summary>
        /// <param name="u"> Value between 0 and 1.</param>
        /// <returns>t value between 0-1</returns>
        protected abstract double MapToT(double u);


        /// <summary>
        /// Finds the on-curve point closest to the specific off-curve point, using a three-pass projection test based on the curve's LUT.
        /// A distance comparison finds the closest match, after which a fine interval around that match is checked to see if a better projection can be found.
        /// </summary>
        public Vector2 Project(Vector2 point)
        {
            return Project(point, out double t, out double d);
        }

        /// <summary>
        /// Finds the on-curve point closest to the specific off-curve point, using a three-pass projection test based on the curve's LUT.
        /// A distance comparison finds the closest match, after which a fine interval around that match is checked to see if a better projection can be found.
        /// </summary>
        public Vector2 Project(Vector2 point, out double t, out double d)
        {


            // step 1: coarse check
            IReadOnlyList<Vector2> LUT = GetLUT();
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
            t1 = MapToT(t1);
            t2 = MapToT(t2);
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
                if (t1 < 0) t1 = 0;
                if (t2 > 1) t2 = 1;
                step /= refinementSteps;
            }

            Vector2 p = Bezier.Position(ft);
            t = ft;
            d = mdist;

            return p;

        }

        /// <summary>Gets the <see cref="Vector2"/> at the specified index.</summary>
        /// <param name="index">The index.</param>
        /// <value>The <see cref="Vector2"/>.</value>
        /// <returns>Point on the Bezier curve at the specified index.</returns>
        public Vector2 this[int index] => GetLUT()[index];

        /// <summary>Gets the number of elements in the lookup table.</summary>
        public int Count => GetLUT().Count;


        /// <summary>Returns an enumerator that iterates through the lookup table.</summary>
        /// <returns>An enumerator that can be used to iterate through the lookup table.</returns>
        public IEnumerator<Vector2> GetEnumerator()
        {
            return GetLUT().GetEnumerator();
        }

        /// <summary>Returns an enumerator that iterates through a  lookup table.</summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the  lookup table.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
