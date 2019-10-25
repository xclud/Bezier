using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace System.Geometry
{
    public interface IPathShape
    {
        /// <summary>
        /// Gets the length of the shape.
        /// </summary>
        double Length { get; }

        Vector2 Position(double t);
        Vector2 Normal(double t);
        Vector2 Tangent(double t);

        Pair<IPathShape> Break(double t);

        Pair<IPathShape> BreakAtPoint(Vector2 pointOfBreak);

        IPathShape Clone();

        BoundingBox BoundingBox
        {
            get;
        }


        /// <summary>
        /// Moves the shape by amount of offset.
        /// </summary>
        /// <param name="offset"></param>
        void Move(Vector2 offset);

        Pair<double>[] Intersects(Circle circle);
        Pair<double>[] Intersects(Arc arc);
        Pair<double>[] Intersects(Line line);
    }
}