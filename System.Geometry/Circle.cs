using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    /// <summary>
    /// Class for circle path.
    /// </summary>
    public sealed class Circle : IPathShape, ITransformable, IInterval
    {
        public Vector2 Center;

        /// <summary>
        /// The radius of the circle.
        /// </summary>
        public float Radius;



        internal Interval Interval;

        Interval IInterval.Interval
        {
            get => Interval;
            set => Interval = value;
        }

        /**
         * Class for circle path, created from radius. Origin will be [0, 0].
         * 
         * Example:
         * ```
         * var c = new Circle(7);
         * ```
         *
         * @param radius The radius of the circle.
         */
        public Circle(float radius)
        {
            Center = new Vector2(0, 0);
            Radius = radius;
        }

        /**
         * Class for circle path, created from origin point and radius.
         *
         * Example:
         * ```
         * var c = new Circle([10, 10], 7);
         * ```
         *
         * @param origin The center point of the circle.
         * @param radius The radius of the circle.
         */
        public Circle(Vector2 center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        /**
         * Class for circle path, created from 2 points.
         *
         * Example:
         * ```
         * var c = new makerjs.paths.Circle([5, 15], [25, 15]);
         * ```
         *
         * @param pointA First point on the circle.
         * @param pointB Second point on the circle.
         */
        public Circle(Vector2 pointA, Vector2 pointB)
        {
            Center = (pointA + pointB) / 2.0f;
            Radius = Vector2.Distance(Center, pointA);
        }

        ///**
        // * Class for circle path, created from 3 points.
        // *
        // * Example:
        // * ```
        // * var c = new makerjs.paths.Circle([0, 0], [0, 10], [20, 0]);
        // * ```
        // *
        // * @param pointA First point on the circle.
        // * @param pointB Second point on the circle.
        // * @param pointC Third point on the circle.
        // */
        //public Circle(Vector2 pointA, Vector2 pointB, Vector2 pointC)
        //{
        //    //create 2 lines with 2nd point in common
        //    Line[] lines = new Line[] {
        //        new Line(pointA, pointB),
        //        new Line(pointB, pointC)
        //    };

        //    //create perpendicular lines
        //    List<Line> perpendiculars = new List<Line>();
        //    for (int i = 2; (i--) != 0;)
        //    {
        //        Vector2 midpoint = lines[i].Middle();
        //        perpendiculars.Add(PathExtensions.Rotate(lines[i], 90, midpoint));
        //    }

        //    //find intersection of slopes of perpendiculars
        //    Vector2? origin = Point.FromSlopeIntersection(perpendiculars[0], perpendiculars[1]);

        //    if (origin != null)
        //    {
        //        Origin = origin.Value;

        //        //radius is distance to any of the 3 points
        //        Radius = Vector2.Distance(Origin, pointA);
        //    }
        //    else
        //    {
        //        throw new Exception("invalid parameters - attempted to construct a circle from 3 points on a line: " + pointA + ", " + pointB + ", " + pointC);
        //    }
        //}

        public float Length
        {
            get
            {
                return 2 * (float)Math.PI * Radius;
            }
        }

        public BoundingBox BoundingBox
        {
            get
            {
                var r = Radius;
                return new BoundingBox
                {
                    Min = Center + new Vector2(-r, -r),
                    Max = Center + new Vector2(r, r)
                };
            }
        }

        public Pair<Arc> Break(float t)
        {
            var midAngle = t * 360;

            var arc1 = new Arc { Center = Center, Radius = Radius, StartAngle = 0, EndAngle = midAngle };
            var arc2 = new Arc { Center = Center, Radius = Radius, StartAngle = midAngle, EndAngle = 360 };

            return new Pair<Arc>(arc1, arc2);
        }

        Pair<IPathShape> IPathShape.Break(float t)
        {
            var b = Break(t);
            if (b == null) return null;
            return new Pair<IPathShape>(b.Left, b.Right);
        }

        public Pair<Arc> BreakAtPoint(Vector2 pointOfBreak)
        {
            var angleAtBreakPoint = Angle.OfPointInDegrees(Center, pointOfBreak);

            var copy1 = new Arc(Center, Radius, angleAtBreakPoint, angleAtBreakPoint + 360);
            var copy2 = new Arc(Center, Radius, angleAtBreakPoint, angleAtBreakPoint + 360);

            return new Pair<Arc>(copy1, copy2);
        }

        Pair<IPathShape> IPathShape.BreakAtPoint(Vector2 pointOfBreak)
        {
            var b = BreakAtPoint(pointOfBreak);
            if (b == null) return null;
            return new Pair<IPathShape>(b.Left, b.Right);
        }

        public Circle Clone()
        {
            return new Circle(Center, Radius);
        }

        IPathShape IPathShape.Clone()
        {
            return Clone();
        }

        internal int NumberOfKeyPoints(float maxPointDistance = 0)
        {
            var len = this.Length;

            if (len == 0) return 0;

            if (maxPointDistance == 0)
            {
                maxPointDistance = len;
            }

            return Math.Max(8, (int)Math.Ceiling(len / (maxPointDistance)));
        }

        internal static Vector2 MidCircle(Circle circle, float midAngle)
        {
            return circle.Center + Point.FromPolar(Angle.ToRadians(midAngle), circle.Radius);
        }

        //public void Rotate(float angleInDegrees, Vector2 rotationOrigin)
        //{
        //    //Nothing todo for a circle.
        //}

        //public override Shape BreakAtPoint(Vector2 pointOfBreak)
        //{
        //    var angleAtBreakPoint = Angle.OfPointInDegrees(Origin, pointOfBreak);

        //    var copy = new Arc(Origin, Radius, angleAtBreakPoint, angleAtBreakPoint + 360)
        //    {
        //        Layer = Layer
        //    };

        //    return copy;
        //}

        public Vector2 Position(float t)
        {
            return MidCircle(this, 360 * t);
        }

        public Vector2 Normal(float t)
        {
            var p = Position(t);
            return Vector2.Normalize(p - Center);
        }

        public Vector2 Tangent(float t)
        {
            var n = Normal(t);
            return new Vector2(-n.Y, n.X);
        }

        //public bool IsPointOnPath(Vector2 pointToCheck, float withinDistance = 0, Vector2 pathOffset = default, IsPointOnPathOptions options = null)
        //{
        //    return Helper.IsPointOnCircle(pointToCheck, this, withinDistance);
        //}

        public IPathShape Clone(Vector2 offset = default)
        {
            return new Circle(Center + offset, Radius);
        }

        public void Move(Vector2 offset)
        {
            Center += offset;
        }


        public void Rotate(float angleInDegrees, Vector2 rotationOrigin)
        {
            Center = Point.Rotate(Center, angleInDegrees, rotationOrigin);
        }

        public Pair<float>[] Intersects(Circle circle)
        {
            return IntersectHelper.Intersect(this, circle)?.ToArray();
        }

        public Pair<float>[] Intersects(Arc arc)
        {
            return IntersectHelper.Intersect(arc, this).Flip()?.ToArray();
        }

        public Pair<float>[] Intersects(Line line)
        {
            return IntersectHelper.Intersect(line, this).Flip()?.ToArray();
        }

        //internal override int NumberOfKeyPoints(float maxPointDistance = 0)
        //{
        //    var len = this.Length;

        //    if (len == 0) return 0;

        //    if (maxPointDistance == 0)
        //    {
        //        maxPointDistance = len;
        //    }

        //    return Math.Max(8, (int)Math.Ceiling(len / (maxPointDistance)));
        //}
    }
}