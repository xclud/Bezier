using System;
using System.Linq;
using System.DoubleNumerics;

namespace System.Geometry
{
    internal static class Point
    {
        /**
         * Get a point from its polar coordinates.
         * 
         * @param angleInRadians The angle of the polar coordinate, in radians.
         * @param radius The radius of the polar coordinate.
         * @returns A new point object.
         */
        public static Vector2 FromPolar(double angleInRadians, double radius)
        {
            return new Vector2((double)(radius * (double)Math.Cos(angleInRadians)), (double)(radius * (double)Math.Sin(angleInRadians)));
        }

        /**
 * Get the two end points of an arc path.
 * 
 * @param arc The arc path object.
 * @returns Array with 2 elements: [0] is the point object corresponding to the start angle, [1] is the point object corresponding to the end angle.
 */
        internal static Vector2[] FromArc(Arc arc)
        {
            return new[] { FromAngleOnArc(arc.StartAngle, arc), FromAngleOnArc(arc.EndAngle, arc) };
        }

        /**
 * Find out if two points are equal.
 * 
 * @param a First point.
 * @param b Second point.
 * @param withinDistance Optional distance to consider points equal.
 * @returns true if points are the same, false if they are not
 */
        internal static bool IsPointEqual(Vector2 a, Vector2 b, double withinDistance = 0)
        {
            if (withinDistance == 0)
            {
                return a.X == b.X && a.Y == b.Y;
            }
            else
            {
                double distance = Vector2.Distance(a, b);
                return distance <= withinDistance;
            }
        }

        /**
    * Calculates the intersection of slopes of two lines.
    * 
    * @param lineA First line to use for slope.
    * @param lineB Second line to use for slope.
    * @param options Optional IPathIntersectionOptions.
    * @returns point of intersection of the two slopes, or null if the slopes did not intersect.
*/
        internal static Vector2? FromSlopeIntersection(Line lineA, Line lineB, out bool AreOverlapped, bool excludeTangents = false)
        {
            var slopeA = Slope.Of(lineA.P1, lineA.P2);
            var slopeB = Slope.Of(lineB.P1, lineB.P2);

            AreOverlapped = false;

            //see if slope are parallel 
            if (Slope.AreParallel(slopeA, slopeB))
            {
                if (Slope.AreEqual(slopeA, slopeB))
                {
                    //check for overlap
                    AreOverlapped = Helper.IsLineOverlapping(lineA, lineB, excludeTangents);
                }

                return null;
            }

            Vector2? pointOfIntersection = null;

            if (!slopeA.HasValue)
            {
                pointOfIntersection = verticalIntersectionPoint(lineA, slopeB);
            }
            else if (!slopeB.HasValue)
            {
                pointOfIntersection = verticalIntersectionPoint(lineB, slopeA);
            }
            else
            {
                // find intersection by line equation
                double x = (slopeB.YIntercept - slopeA.YIntercept) / (slopeA.Value - slopeB.Value);
                double y = slopeA.Value * x + slopeA.YIntercept;
                pointOfIntersection = new Vector2((double)x, (double)y);
            }

            return pointOfIntersection;
        }

        private static Vector2 verticalIntersectionPoint(Line verticalLine, Slope nonVerticalSlope)
        {
            double x = verticalLine.P1.X;
            double y = nonVerticalSlope.Value * x + nonVerticalSlope.YIntercept;
            return new Vector2((double)x, (double)y);
        }


        /**
    * Get a point on a circle or arc path, at a given angle.
    * @param angleInDegrees The angle at which you want to find the point, in degrees.
    * @param circle A circle or arc.
    * @returns A new point object.
*/
        internal static Vector2 FromAngleOnArc(double angleInDegrees, Arc arc)
        {
            return arc.Center + FromPolar(Angle.ToRadians(angleInDegrees), arc.Radius);
        }

        internal static Vector2 FromAngleOnCircle(double angleInDegrees, Circle circle)
        {
            return circle.Center + FromPolar(Angle.ToRadians(angleInDegrees), circle.Radius);
        }

        internal static Vector2 FromAngleOnCircle(double angleInDegrees, Arc arc)
        {
            return arc.Center + FromPolar(Angle.ToRadians(angleInDegrees), arc.Radius);
        }

        /**
 * Get the two end points of a path.
 * 
 * @param pathContext The path object.
 * @returns Array with 2 elements: [0] is the point object corresponding to the origin, [1] is the point object corresponding to the end.
 */
        internal static Vector2[] FromPathEnds(IPathShape pathContext, Vector2 pathOffset = default)
        {
            Vector2[] result = null;

            if (pathContext is Arc)
            {
                result = Point.FromArc(pathContext as Arc);
            }
            else if (pathContext is Line line)
            {
                result = new Vector2[] { line.P1, line.P2 };
            }
            else if (pathContext is Bezier bc)
            {
                result = new Vector2[] { bc.Points[0], bc.Points.Last() };
            }

            if (result != null)
            {
                result = result.Select(p => p + pathOffset).ToArray();
            }

            return result;
        }

        /**
 * Rotate a point.
 * 
 * @param pointToRotate The point to rotate.
 * @param angleInDegrees The amount of rotation, in degrees.
 * @param rotationOrigin The center point of rotation.
 * @returns A new point.
 */
        internal static Vector2 Rotate(Vector2 pointToRotate, double angleInDegrees, Vector2 rotationOrigin = default)
        {
            double pointAngleInRadians = Angle.OfPointInRadians(rotationOrigin, pointToRotate);
            double d = Vector2.Distance(rotationOrigin, pointToRotate);
            Vector2 rotatedPoint = FromPolar(pointAngleInRadians + Angle.ToRadians(angleInDegrees), d);

            return rotationOrigin + rotatedPoint;
        }
    }
}