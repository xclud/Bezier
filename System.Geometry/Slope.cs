using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    /// <summary>
    /// Represents a Slope of Line.
    /// </summary>
    public class Slope
    {
        /// <summary>
        /// Value of the Slope.
        /// </summary>
        public readonly double Value;

        /// <summary>
        /// If false, the slope is vertical.
        /// </summary>
        public readonly bool HasValue;

        /// <summary>
        /// Y-Intercept.
        /// </summary>
        public readonly double YIntercept;

        private readonly Line line;

        private Slope(bool hasValue, double slope, double yIntercept, Line line)
        {
            this.HasValue = hasValue;
            this.Value = slope;
            this.YIntercept = yIntercept;
            this.line = line;
        }


        /// <summary>
        /// Gets the slope of a line.
        /// </summary>
        public static Slope Of(Line line)
        {
            return Of(line.P1, line.P2);
        }


        /// <summary>
        /// Gets the slope of a line.
        /// </summary>
        public static Slope Of(Vector2 p1, Vector2 p2)
        {
            double dx = p2.X - p1.X;
            var l = new Line(p1, p2);

            if (dx == 0)
            {
                return new Slope(false, 0, 0, l);
            }

            double dy = p2.Y - p1.Y;

            double slope = dy / dx;
            double yIntercept = p1.Y - slope * p1.X;

            return new Slope(true, slope, yIntercept, l);
        }


        /// <summary>
        /// Check for slope equality.
        /// </summary>
        /// <param name="slopeA">First Slope.</param>
        /// <param name="slopeB">Second Slope.</param>
        /// <returns>Returns if the two slopes are equal.</returns>
        public static bool AreEqual(Slope slopeA, Slope slopeB)
        {
            if (!AreParallel(slopeA, slopeB)) return false;

            if (!slopeA.HasValue && !slopeB.HasValue)
            {
                //lines are both vertical, see if x are the same
                return slopeA.line.P1.X == slopeB.line.P1.X;
            }

            //lines are parallel, but not vertical, see if y-intercept is the same
            return slopeA.YIntercept == slopeB.YIntercept;
        }

        /// <summary>
        /// Checks if slopes are parallel.
        /// </summary>
        /// <param name="slopeA">First Slope.</param>
        /// <param name="slopeB">Second Slope.</param>
        /// <returns>True if the slopes are parallel.</returns>
        public static bool AreParallel(Slope slopeA, Slope slopeB)
        {
            if (!slopeA.HasValue && !slopeB.HasValue)
            {
                return true;
            }

            if (slopeA.HasValue && slopeB.HasValue && slopeA.Value == slopeB.Value)
            {
                //lines are parallel
                return true;
            }

            return false;
        }
    }
}