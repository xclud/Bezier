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
        float Length { get; }

        Vector2 Position(float t);
        Vector2 Normal(float t);
        Vector2 Tangent(float t);

        Pair<IPathShape> Break(float t);

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

        Pair<float>[] Intersects(Circle circle);
        Pair<float>[] Intersects(Arc arc);
        Pair<float>[] Intersects(Line line);
    }
}