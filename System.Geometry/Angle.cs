using System;
using System.DoubleNumerics;

namespace System.Geometry
{
    internal static class Angle
    {
        public static double OfPointInDegrees(Vector2 origin, Vector2 pointToFindAngle)
        {
            return ToDegrees(OfPointInRadians(origin, pointToFindAngle));
        }

        /**
 * Angle of a line path.
 * 
 * @param line The line path to find the angle of.
 * @returns Angle of the line path, in degrees.
 */
        public static double OfLineInDegrees(Line line)
        {
            return NoRevolutions(ToDegrees(OfPointInRadians(line.P1, line.P2)));
        }


        /**
         * Split a decimal into its whole and fractional parts as strings.
         * 
         * Example: get whole and fractional parts of 42.056
         * ```
         * makerjs.splitDecimal(42.056); //returns ["42", "056"]
         * ```
         * 
         * @param n The number to split.
         * @returns Array of 2 strings when n contains a decimal point, or an array of one string when n is an integer.
         */
        public static double[] splitDecimal(double n)
        {
            var intt = (int)Math.Floor(n);
            var frac = n - intt;

            return new[] { intt, frac };
        }

        private static double getFractionalPart(double n)
        {
            return splitDecimal(n)[1];
        }


        private static double setFractionalPart(double n, double fractionalPart)
        {
            return splitDecimal(n)[0] + fractionalPart;
        }

        public static double copyFractionalPart(double src, double dest)
        {
            if ((src < 0 && dest < 0) || (src > 0 && dest > 0))
            {
                return setFractionalPart(dest, getFractionalPart(src));
            }
            return dest;
        }

        /**
 * Ensures an angle is not greater than 360
 * 
 * @param angleInDegrees Angle in degrees.
 * @returns Same polar angle but not greater than 360 degrees.
 */
        public static double NoRevolutions(double angleInDegrees)
        {
            var revolutions = (int)Math.Floor(angleInDegrees / 360);
            if (revolutions == 0) return angleInDegrees;
            var a = angleInDegrees - (360 * revolutions);
            return copyFractionalPart(angleInDegrees, a);
        }

        /**
* Angle of a line through a point, in radians.
* 
* @param pointToFindAngle The point to find the angle.
* @param origin Point of origin of the angle.
* @returns Angle of the line throught the point, in radians.
*/
        internal static double OfPointInRadians(Vector2 origin, Vector2 pointToFindAngle)
        {
            Vector2 d = pointToFindAngle - origin;
            double x = d.X;
            double y = d.Y;

            return (double)Math.Atan2(-y, -x) + (double)Math.PI;
        }

        public static double ToRadians(double angleInDegrees)
        {
            return NoRevolutions(angleInDegrees) * (double)Math.PI / 180.0D;
        }

        public static double ToDegrees(double angleInRadians)
        {
            return angleInRadians * 180.0d / (double)Math.PI;
        }

        /// <summary>
        /// Mirror an angle on either or both x and y axes.
        /// </summary>
        /// <param name="angleInDegrees">The angle to mirror.</param>
        /// <param name="mirrorX">Boolean to mirror on the x axis.</param>
        /// <param name="mirrorY">Boolean to mirror on the y axis.</param>
        /// <returns>Mirrored angle.</returns>
        public static double Mirror(double angleInDegrees, bool mirrorX, bool mirrorY)
        {
            if (mirrorY)
            {
                angleInDegrees = 360 - angleInDegrees;
            }

            if (mirrorX)
            {
                angleInDegrees = (angleInDegrees < 180 ? 180 : 540) - angleInDegrees;
            }

            return angleInDegrees;
        }


        /// <summary>
        /// Get an arc's end angle, ensured to be greater than its start angle.
        /// </summary>
        /// <param name="arc">An arc path object.</param>
        /// <returns>End angle of arc</returns>
        public static double OfArcEnd(Arc arc)
        {
            //compensate for values past zero. This allows easy compute of total angle size.
            //for example 0 = 360
            if (arc.EndAngle < arc.StartAngle)
            {
                var revolutions = (int)Math.Ceiling((arc.StartAngle - arc.EndAngle) / 360);
                var a = revolutions * 360 + arc.EndAngle;
                return copyFractionalPart(arc.EndAngle, a);
            }
            return arc.EndAngle;
        }

        /**
 * Get the angle in the middle of an arc's start and end angles.
 * 
 * @param arc An arc path object.
 * @param ratio Optional number between 0 and 1 specifying percentage between start and end angles.
 * @returns Middle angle of arc.
 */
        public static double OfArcMiddle(Arc arc, double t)
        {
            return arc.StartAngle + OfArcSpan(arc) * t;
        }

        /**
         * Total angle of an arc between its start and end angles.
         * 
         * @param arc The arc to measure.
         * @returns Angle of arc.
         */
        public static double OfArcSpan(Arc arc)
        {
            var endAngle = OfArcEnd(arc);
            var a = endAngle - arc.StartAngle;
            if (a > 360)
            {
                return NoRevolutions(a);
            }
            else
            {
                return a;
            }
        }
    }
}