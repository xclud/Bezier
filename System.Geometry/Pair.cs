using System;
using System.Collections.Generic;

namespace System.Geometry
{
    public class Pair<T>
    {
        public T Left;
        public T Right;


        public Pair()
        {

        }

        internal Pair<T> Flip()
        {
            return new Pair<T>(Right, Left);
        }

        public Pair(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Converts the pair to string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Left} : {Right}";
        }

        internal class EqualityComparer : IEqualityComparer<Pair<T>>
        {
            public bool Equals(Pair<T> x, Pair<T> y)
            {
                if (object.ReferenceEquals(x, y))
                {
                    return true;
                }

                return x.Left.Equals(y.Left) && x.Right.Equals(y.Right);
            }

            public int GetHashCode(Pair<T> obj)
            {
                return obj.Left.GetHashCode() ^ obj.Right.GetHashCode();
            }
        }
    }
}