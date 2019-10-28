using System;
using System.Collections.Generic;
using System.Linq;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry
{
    public class CompoundPath
    {
        public Vector2 Start;
        internal Vector2 End;

        private readonly List<IPathShape> shapes = new List<IPathShape>();

        public IReadOnlyList<IPathShape> Shapes => shapes;

        public CompoundPath ArcTo(double radius, double startAngle, double endAngle)
        {
            shapes.Add(new Arc { Radius = radius, StartAngle = startAngle, EndAngle = endAngle });
            return this;
        }


        public CompoundPath LineTo(Vector2 point)
        {
            shapes.Add(new Line { P1 = End, P2 = point });
            End = point;
            return this;
        }


        public CompoundPath CurveTo(params Vector2[] controlPoints)
        {
            var list = new List<Vector2>
            {
                End
            };
            list.AddRange(controlPoints);

            var bez = new Bezier(list);


            shapes.AddRange(bez.ToArcs());
            End = controlPoints.Last();

            return this;
        }

        public double Length
        {
            get
            {
                return shapes.Sum(shp => shp.Length);
            }
        }

        public void Offset(Vector2 offset)
        {
            Start += offset;
            End += offset;

            foreach (var shape in shapes)
            {
                shape.Move(offset);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"M {Start.X} {Start.Y}");

            foreach (var shape in shapes)
            {
                if (shape is Line line)
                {
                    sb.Append(" ");
                    sb.Append($"L {line.P2.X} {line.P2.Y}");
                }
                if (shape is Arc arc)
                {
                    sb.Append(" ");
                    sb.Append(arc.ToString(false));
                }
                else if (shape is Bezier bezier)
                {
                    if (bezier.order == 2)
                    {
                        sb.Append(" ");
                        sb.Append($"Q {bezier.Points[1].X} {bezier.Points[1].Y} {bezier.Points[2].X} {bezier.Points[2].Y}");
                    }
                    else if (bezier.order == 3)
                    {
                        sb.Append(" ");
                        sb.Append($"C {bezier.Points[1].X} {bezier.Points[1].Y} {bezier.Points[2].X} {bezier.Points[2].Y} {bezier.Points[3].X} {bezier.Points[3].Y}");
                    }
                }
            }

            return sb.ToString();
        }
    }
}