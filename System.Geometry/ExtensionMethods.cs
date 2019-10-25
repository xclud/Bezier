using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Geometry
{
    /// <summary>
    /// Provides a set of extension methods for shape classes.
    /// </summary>
    public static class ExtensionMethods
    {
        internal static IEnumerable<Pair<T>> Flip<T>(this IEnumerable<Pair<T>> list)
        {
            return list?.Select(i => new Pair<T>(i.Right, i.Left));
        }

        public static Pair<float>[] Intersects(this IPathShape shape, IPathShape other)
        {
            if (other is Line line)
            {
                return shape.Intersects(line);
            }
            else if (other is Circle circle)
            {
                return shape.Intersects(circle);
            }
            else if (other is Arc arc)
            {
                return shape.Intersects(arc);
            }

            throw new ArgumentException();
        }

        public static IEnumerable<IPathShape> Break(this IPathShape shape, params float[] vs)
        {
            return BreakInternal(shape, vs);
        }

        public static IEnumerable<IPathShape> Break(this IPathShape shape, IEnumerable<float> vs)
        {
            return BreakInternal(shape, vs);
        }

        public static IEnumerable<Line> Break(this Line line, params float[] vs)
        {
            return BreakInternal(line, vs);
        }

        public static IEnumerable<Line> Break(this Line line, IEnumerable<float> vs)
        {
            return BreakInternal(line, vs);
        }

        public static IEnumerable<Arc> Break(this Arc arc, params float[] vs)
        {
            return BreakInternal(arc, vs);
        }

        public static IEnumerable<Arc> Break(this Arc arc, IEnumerable<float> vs)
        {
            return BreakInternal(arc, vs);
        }

        public static IEnumerable<Arc> Break(this Circle arc, params float[] vs)
        {
            return BreakInternal(arc, vs);
        }

        public static IEnumerable<Arc> Break(this Circle arc, IEnumerable<float> vs)
        {
            return BreakInternal(arc, vs);
        }


        private static IEnumerable<IPathShape> BreakInternal(IPathShape shape, IEnumerable<float> vs)
        {
            var u = 0f;
            var any = false;

            foreach (var t in vs)
            {
                var r = Utils.Map(t, u, 1, 0, 1);

                var items = shape.Break(r);

                if (items == null)
                {
                    break;
                }

                u += t;
                any = true;

                shape = items.Right;
                yield return items.Left;
            }

            if (any)
            {
                yield return shape;
            }
        }


        private static IEnumerable<Line> BreakInternal(Line shape, IEnumerable<float> vs)
        {
            var u = 0f;
            var any = false;

            foreach (var t in vs)
            {
                var r = Utils.Map(t, u, 1, 0, 1);

                var items = shape.Break(r);

                if (items == null)
                {
                    break;
                }

                u += t;
                any = true;

                shape = items.Right;
                yield return items.Left;
            }

            if (any)
            {
                yield return shape;
            }
        }

        private static IEnumerable<Arc> BreakInternal(Arc shape, IEnumerable<float> vs)
        {
            var u = 0f;
            var any = false;

            foreach (var t in vs)
            {
                var r = Utils.Map(t, u, 1, 0, 1);

                var items = shape.Break(r);

                if (items == null)
                {
                    break;
                }

                u += t;
                any = true;

                shape = items.Right;
                yield return items.Left;
            }

            if (any)
            {
                yield return shape;
            }
        }

        private static IEnumerable<Arc> BreakInternal(Circle shape, IEnumerable<float> vs)
        {
            Arc last = null;
            var u = 0f;
            var any = false;

            foreach (var t in vs)
            {
                var r = Utils.Map(t, u, 1, 0, 1);

                Pair<Arc> items = null;

                if (last != null)
                {
                    items = last.Break(r);
                }
                else
                {
                    items = shape.Break(r);
                }

                if (items == null)
                {
                    break;
                }

                u += t;
                any = true;

                last = items.Right;
                yield return items.Left;
            }

            if (last != null)
            {
                yield return last;
            }
        }
    }
}