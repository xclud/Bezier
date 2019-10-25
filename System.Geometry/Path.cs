using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    public class Path
    {
        readonly List<CompoundPath> segments = new List<CompoundPath>();

        public IReadOnlyList<CompoundPath> Segments => segments;

        private CompoundPath current;

        public Path MoveTo(double x, double y)
        {
            current = new CompoundPath { Start = new Vector2(x, y), End = new Vector2(x, y) };
            segments.Add(current);

            return this;
        }

        public Path MoveTo(Vector2 p)
        {
            current = new CompoundPath { Start = p, End = p };
            segments.Add(current);

            return this;
        }


        public Path LineTo(double x, double y)
        {
            current.LineTo(new Vector2(x, y));
            return this;
        }

        public Path LineTo(Vector2 p)
        {
            current.LineTo(p);
            return this;
        }


        public Path CurveTo(params Vector2[] controlPoints)
        {
            current.CurveTo(controlPoints);
            return this;
        }

        public Path ArcTo(double radius, double startAngle, double endAngle)
        {
            current.ArcTo(radius, startAngle, endAngle);
            return this;
        }

        public void Offset(Vector2 offset)
        {
            foreach (var segment in segments)
            {
                segment.Offset(offset);
            }
        }

        public override string ToString()
        {
            return string.Join("\r\n", segments);
        }
    }
}