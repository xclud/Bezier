using System;
using System.Collections.Generic;
using System.Linq;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    public sealed class Arc : IPathShape, ITransformable, IInterval
    {
        public Vector2 Center;

        /// <summary>
        /// The radius of the circle.
        /// </summary>
        public double Radius;

        /// <summary>
        /// The angle (in degrees) to begin drawing the arc, in polar (counter-clockwise) direction.
        /// </summary>
        public double StartAngle;

        /// <summary>
        /// The angle (in degrees) to end drawing the arc, in polar (counter-clockwise) direction. May be less than start angle if it past 360.
        /// </summary>
        public double EndAngle;

        internal Interval Interval;

        Interval IInterval.Interval
        {
            get => Interval;
            set => Interval = value;
        }

        public Arc()
        {

        }

        public Arc(Vector2 center, double radius, double startAngle, double endAngle)
        {
            this.Center = center;
            this.Radius = radius;
            this.StartAngle = startAngle;
            this.EndAngle = endAngle;
        }
        /**
         * Class for arc path, created from 2 points and optional bool flag indicating clockwise.
         * 
         * @param pointA First end point of the arc.
         * @param pointB Second end point of the arc.
         * @param clockwise bool flag to indicate clockwise direction.
         */
        public Arc(Vector2 pointA, Vector2 pointB, bool clockwise = false)
        {
            Center = (pointA + pointB) / 2.0d;
            Radius = Vector2.Distance(Center, pointA);

            StartAngle = Angle.OfPointInDegrees(Center, clockwise ? pointB : pointA);
            EndAngle = Angle.OfPointInDegrees(Center, clockwise ? pointA : pointB);
        }

        /**
         * Class for arc path, created from 3 points.
         * 
         * @param pointA First end point of the arc.
         * @param pointB Middle point on the arc.
         * @param pointC Second end point of the arc.
         */
        public static Arc FromPoints(Vector2 pointA, Vector2 pointB, Vector2 pointC)
        {
            //create 2 lines with 2nd point in common
            var lines = new[] {
                new Line(pointA, pointB),
                new Line(pointB, pointC)
            };

            //create perpendicular lines
            List<Line> perpendiculars = new List<Line>();
            for (int i = 2; (i--) != 0;)
            {
                Vector2 midpoint = lines[i].Position(0.5d);
                lines[i].Rotate(90, midpoint);
                perpendiculars.Add(lines[i]);
            }

            //find intersection of slopes of perpendiculars
            Vector2? origin = Point.FromSlopeIntersection(perpendiculars[0], perpendiculars[1], out var overlapped);

            if (origin == null)
            {
                return null;
            }

            var Center = origin.Value;

            //radius is distance to any of the 3 points
            var Radius = Vector2.Distance(Center, pointA);


            double[] angles = new double[]
            {
                Angle.OfPointInDegrees(Center, pointA),
                Angle.OfPointInDegrees(Center, pointB),
                Angle.OfPointInDegrees(Center, pointC)
            };

            var StartAngle = angles[0];
            var EndAngle = angles[2];

            var arc = new Arc(Center, Radius, StartAngle, EndAngle);

            //swap start and end angles if this arc does not contain the midpoint
            if (!Helper.IsBetweenArcAngles(arc, angles[1], false))
            {
                arc.StartAngle = angles[2];
                arc.EndAngle = angles[0];
            }

            return arc;
        }

        /// <summary>
        /// Returns the length of this Arc.
        /// </summary>
        public double Length
        {
            get
            {
                var value = 2 * (double)Math.PI * Radius;

                var pct = Angle.OfArcSpan(this) / 360;
                value *= pct;
                return value;
            }
        }


        public BoundingBox BoundingBox
        {
            get
            {
                var r = Radius;
                var arcPoints = Point.FromArc(this);

                Vector2 extremeAngleMin(double xAngle, double yAngle, double value)
                {
                    var extremePoint = Vector2.Min(arcPoints[0], arcPoints[1]);

                    if (Helper.IsBetweenArcAngles(this, xAngle, false))
                    {
                        extremePoint.X = (double)value + this.Center.X;
                    }

                    if (Helper.IsBetweenArcAngles(this, yAngle, false))
                    {
                        extremePoint.Y = (double)value + this.Center.Y;
                    }

                    return extremePoint;
                }

                Vector2 extremeAngleMax(double xAngle, double yAngle, double value)
                {
                    var extremePoint = Vector2.Max(arcPoints[0], arcPoints[1]);

                    if (Helper.IsBetweenArcAngles(this, xAngle, false))
                    {
                        extremePoint.X = (double)value + this.Center.X;
                    }

                    if (Helper.IsBetweenArcAngles(this, yAngle, false))
                    {
                        extremePoint.Y = (double)value + this.Center.Y;
                    }

                    return extremePoint;
                }

                return new BoundingBox
                {
                    Min = extremeAngleMin(180, 270, -r),
                    Max = extremeAngleMax(360, 90, r)
                };
            }
        }



        internal static Vector2 MidCircle(Arc arc, double midAngle)
        {
            return arc.Center + Point.FromPolar(Angle.ToRadians(midAngle), arc.Radius);
        }



        public Vector2 Position(double t)
        {
            var midAngle = Angle.OfArcMiddle(this, t);
            return MidCircle(this, midAngle);
        }

        public Vector2 Normal(double t)
        {
            var p = Position(t);
            return Vector2.Normalize(p - Center);
        }

        public Vector2 Tangent(double t)
        {
            var n = Normal(t);
            return new Vector2(-n.Y, n.X);
        }

        public double AngleOf(double t)
        {
            return this.StartAngle + Span * t;
        }

        public double Span
        {
            get
            {
                var a = End - this.StartAngle;
                if (a > 360)
                {
                    return Angle.NoRevolutions(a);
                }
                else
                {
                    return a;
                }
            }
        }

        /// <summary>
        /// Get an arc's end angle, ensured to be greater than its start angle.
        /// </summary>
        private double End
        {
            get
            {
                //compensate for values past zero. This allows easy compute of total angle size.
                //for example 0 = 360
                if (this.EndAngle < this.StartAngle)
                {
                    var revolutions = (int)Math.Ceiling((this.StartAngle - this.EndAngle) / 360.0d);
                    var a = revolutions * 360 + this.EndAngle;
                    return Angle.copyFractionalPart(this.EndAngle, a);
                }
                return this.EndAngle;
            }
        }

        public Pair<Arc> Break(double t)
        {
            var midAngle = Angle.OfArcMiddle(this, t);

            var arc1 = new Arc { Center = Center, Radius = Radius, StartAngle = StartAngle, EndAngle = midAngle };
            var arc2 = new Arc { Center = Center, Radius = Radius, StartAngle = midAngle, EndAngle = EndAngle };

            return new Pair<Arc>(arc1, arc2);
        }

        Pair<IPathShape> IPathShape.BreakAtPoint(Vector2 pointOfBreak)
        {
            var b = BreakAtPointInternal(this.Clone() as Arc, pointOfBreak);
            if (b == null) return null;
            return new Pair<IPathShape>(b.Left, b.Right);
        }

        public Pair<Arc> BreakAtPoint(Vector2 pointOfBreak)
        {
            return BreakAtPointInternal(this.Clone() as Arc, pointOfBreak);
        }

        private static Pair<Arc> BreakAtPointInternal(Arc arc, Vector2 pointOfBreak)
        {
            var angleAtBreakPoint = Angle.OfPointInDegrees(arc.Center, pointOfBreak);

            if (Helper.IsAngleEqual(angleAtBreakPoint, arc.StartAngle) || Helper.IsAngleEqual(angleAtBreakPoint, arc.EndAngle))
            {
                return null;
            }

            double? getAngleStrictlyBetweenArcAngles()
            {
                var startAngle = Angle.NoRevolutions(arc.StartAngle);
                var endAngle = startAngle + Angle.OfArcEnd(arc) - arc.StartAngle;

                var tries = new double[] { 0, 1, -1 };
                for (var i = 0; i < tries.Length; i++)
                {
                    var add = +360 * tries[i];
                    if (Helper.IsBetween(angleAtBreakPoint + add, startAngle, endAngle, true))
                    {
                        return arc.StartAngle + angleAtBreakPoint + add - startAngle;
                    }
                }
                return null;
            }

            var angleAtBreakPointBetween = getAngleStrictlyBetweenArcAngles();
            if (angleAtBreakPointBetween == null)
            {
                return null;
            }

            var savedEndAngle = arc.EndAngle;

            arc.EndAngle = angleAtBreakPointBetween.GetValueOrDefault();

            //clone the original to carry other properties
            var copy = arc.Clone() as Arc;
            copy.StartAngle = angleAtBreakPointBetween.GetValueOrDefault();
            copy.EndAngle = savedEndAngle;

            return new Pair<Arc>(arc, copy);
        }


        public Arc Clone()
        {
            return new Arc(Center, Radius, StartAngle, EndAngle);
        }

        IPathShape IPathShape.Clone()
        {
            return Clone();
        }

        public void Move(Vector2 offset)
        {
            Center += offset;
        }

        public void Rotate(double angleInDegrees, Vector2 rotationOrigin)
        {
            Center = Point.Rotate(Center, angleInDegrees, rotationOrigin);
            this.StartAngle = Angle.NoRevolutions(StartAngle + angleInDegrees);
            this.EndAngle = Angle.NoRevolutions(EndAngle + angleInDegrees);
        }


        static void CorrectArc(Arc arc)
        {
            var arcSpan = Angle.OfArcSpan(arc);
            arc.StartAngle = Angle.NoRevolutions(arc.StartAngle);
            arc.EndAngle = arc.StartAngle + arcSpan;
        }

        static string WriteArcData(double radius, Vector2 start, Vector2 endPoint, bool largeArc = false, bool increasing = false)
        {
            var end = endPoint;

            var d = new List<object>();
            d.Add("M");
            d.Add(start.X);
            d.Add(start.Y);
            d.Add("A");
            d.Add(radius);
            d.Add(radius);
            d.Add(0);                   //0 = x-axis rotation
            d.Add(largeArc ? 1 : 0);    //large arc=1, small arc=0
            d.Add(increasing ? 0 : 1);  //sweep-flag 0=increasing, 1=decreasing 
            d.Add(endPoint.X);
            d.Add(endPoint.Y);

            return string.Join(" ", d);
        }


        public string ToString(bool includeStartPoint = true)
        {
            var arc = new Arc
            {
                Center = Center,
                EndAngle = EndAngle,
                StartAngle = StartAngle,
                Radius = Radius,
            };

            CorrectArc(arc);
            var arcPoints = Point.FromArc(arc);

            var start = arcPoints[0];
            var end = arcPoints[1];
            var largeArc = Angle.OfArcSpan(arc) > 180;
            var increasing = arc.StartAngle > arc.EndAngle;

            var d = new List<object>();
            if (includeStartPoint)
            {
                d.Add("M");
                d.Add(start.X);
                d.Add(start.Y);
            }

            d.Add("A");
            d.Add(this.Radius);
            d.Add(this.Radius);
            d.Add(0);                   //0 = x-axis rotation
            d.Add(largeArc ? 1 : 0);    //large arc=1, small arc=0
            d.Add(increasing ? 0 : 1);  //sweep-flag 0=increasing, 1=decreasing 
            d.Add(end.X);
            d.Add(end.Y);

            return string.Join(" ", d);
        }

        public override string ToString()
        {
            var arc = new Arc
            {
                Center = Center,
                EndAngle = EndAngle,
                StartAngle = StartAngle,
                Radius = Radius,
            };

            CorrectArc(arc);
            var arcPoints = Point.FromArc(arc);

            if (Point.IsPointEqual(arcPoints[0], arcPoints[1]))
            {
                //return svgPathDataMap[pathType.Circle](arc, accuracy);
            }

            return WriteArcData(arc.Radius, arcPoints[0], arcPoints[1], Angle.OfArcSpan(arc) > 180, arc.StartAngle > arc.EndAngle);
        }

        Pair<IPathShape> IPathShape.Break(double t)
        {
            var b = Break(t);
            if (b == null) return null;
            return new Pair<IPathShape>(b.Left, b.Right);
        }

        public Pair<double>[] Intersects(Line line)
        {
            return IntersectHelper.Intersect(line, this).Flip()?.ToArray();
        }

        public Pair<double>[] Intersects(Arc arc)
        {
            return IntersectHelper.Intersect(this, arc)?.ToArray();
        }

        public Pair<double>[] Intersects(Circle circle)
        {
            return IntersectHelper.Intersect(this, circle)?.ToArray();
        }


        /// <summary>
        /// Check if a given angle is between an arc's start and end angles.
        /// </summary>
        /// <param name="arc">Arc to test against.</param>
        /// <param name="angleInQuestion">The angle to test.</param>
        /// <param name="exclusive">Flag to exclude equaling the start or end angles.</param>
        /// <returns>Boolean true if angle is between (or equal to) the arc's start and end angles.</returns>
        public bool IsAngleOnArc(double angleInQuestion, bool exclusive)
        {
            double startAngle = Angle.NoRevolutions(this.StartAngle);
            double endAngle = startAngle + Span;

            angleInQuestion = Angle.NoRevolutions(angleInQuestion);

            //computed angles will not be negative, but the arc may have specified a negative angle, so check against one revolution forward and backward
            return Helper.IsBetween(angleInQuestion, startAngle, endAngle, exclusive) || Helper.IsBetween(angleInQuestion, startAngle + 360, endAngle + 360, exclusive) || Helper.IsBetween(angleInQuestion, startAngle - 360, endAngle - 360, exclusive);
        }


        //internal override int NumberOfKeyPoints(double maxPointDistance = 0)
        //{
        //    var len = this.Length;
        //    if (len == 0) return 0;

        //    var minPoints = (int)Math.Ceiling(Angle.OfArcSpan(this) / 45) + 1;

        //    if (maxPointDistance <= 0)
        //    {
        //        maxPointDistance = len;
        //    }

        //    return Math.Max(minPoints, (int)Math.Ceiling(len / maxPointDistance));
        //}
    }
}