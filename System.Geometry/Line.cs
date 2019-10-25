using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    /// <summary>
    /// Reperesents a Line-Segment.
    /// </summary>
    public class Line : IPathShape, ITransformable, IInterval
    {
        public Vector2 P1;
        public Vector2 P2;


        internal Interval Interval;

        Interval IInterval.Interval
        {
            get => Interval;
            set => Interval = value;
        }

        public Line()
        {

        }

        public Line(Vector2 p1, Vector2 p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }


        /// <summary>
        /// Converts this line segment into SVG text.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"M {P1.X} {P1.Y} L {P2.X} {P2.Y}";
        }

        /// <summary>
        /// Moves the line segment by the offset.
        /// </summary>
        /// <param name="offset">The offset.</param>
        public void Move(Vector2 offset)
        {
            P1 += offset;
            P2 += offset;
        }

        /// <summary>
        /// Rotates the line segment around a rotation origin by specifies angle.
        /// </summary>
        /// <param name="angleInDegrees">Angle in Degrees.</param>
        /// <param name="rotationOrigin">Rotation origin.</param>
        public void Rotate(float angleInDegrees, Vector2 rotationOrigin)
        {
            P1 = Point.Rotate(P1, angleInDegrees, rotationOrigin);
            P2 = Point.Rotate(P2, angleInDegrees, rotationOrigin);
        }

        public Vector2 Position(float t)
        {
            return Vector2.Lerp(P1, P2, t);
        }

        public Vector2 Tangent(float t)
        {
            return Vector2.Normalize(P2 - P1);
        }

        public Vector2 Normal(float t)
        {
            var sub = P2 - P1;
            var d = Vector2.Distance(P1, P2);
            var n = new Vector2(x: -sub.Y / d, y: sub.X / d);

            return n;
        }

        public Pair<Line> Break(float t)
        {
            var p = Position(t);
            var line1 = new Line(P1, p);
            var line2 = new Line(p, P2);

            return new Pair<Line>(line1, line2);
        }

        public Pair<Line> BreakAtPoint(Vector2 pointOfBreak)
        {
            if (!Helper.IsBetweenPoints(pointOfBreak, this, true))
            {
                return null;
            }

            var l1 = new Line(P1, pointOfBreak);
            var l2 = new Line(pointOfBreak, P2);

            return new Pair<Line>(l1, l2);
        }

        Pair<IPathShape> IPathShape.BreakAtPoint(Vector2 pointOfBreak)
        {
            var b = BreakAtPoint(pointOfBreak);
            if (b == null) return null;
            return new Pair<IPathShape>(b.Left, b.Right);
        }

        Pair<IPathShape> IPathShape.Break(float t)
        {
            var b = Break(t);
            if (b == null) return null;
            return new Pair<IPathShape>(b.Left, b.Right);
        }

        public Line Clone()
        {
            return new Line(P1, P2);
        }

        IPathShape IPathShape.Clone()
        {
            return Clone();
        }

        /// <summary>
        /// Returns the length of the line segment.
        /// </summary>
        public float Length => Vector2.Distance(P1, P2);

        public BoundingBox BoundingBox
        {
            get
            {
                return new BoundingBox
                {
                    Min = Vector2.Min(P1, P2),
                    Max = Vector2.Max(P2, P2)
                };
            }
        }

        public Pair<float>[] Intersects(Circle circle)
        {
            return IntersectHelper.Intersect(this, circle);
        }
        public Pair<float>[] Intersects(Arc arc)
        {
            return IntersectHelper.Intersect(this, arc)?.ToArray();
        }

        public Pair<float>[] Intersects(Line line)
        {
            return IntersectHelper.Intersect(this, line);
        }


        //internal override int NumberOfKeyPoints(float maxPointDistance = 0)
        //{
        //    return 2;
        //}
    }
}