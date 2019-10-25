//Based on https://github.com/Pomax/bezierjs/blob/master/lib/utils.js
//Some small bugfixes by lk, 25.10.2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace System.Geometry
{
    static public class Utils
    {
        const float epsilon = 0.000001f;

        // Legendre-Gauss abscissae with n=24 (x_i values, defined at i=n as the roots of the nth order Legendre polynomial Pn(x))
        private static readonly float[] Tvalues = new[] {
          -0.0640568928626056260850430826247450385909f,
          0.0640568928626056260850430826247450385909f,
          -0.1911188674736163091586398207570696318404f,
          0.1911188674736163091586398207570696318404f,
          -0.3150426796961633743867932913198102407864f,
          0.3150426796961633743867932913198102407864f,
          -0.4337935076260451384870842319133497124524f,
          0.4337935076260451384870842319133497124524f,
          -0.5454214713888395356583756172183723700107f,
          0.5454214713888395356583756172183723700107f,
          -0.6480936519369755692524957869107476266696f,
          0.6480936519369755692524957869107476266696f,
          -0.7401241915785543642438281030999784255232f,
          0.7401241915785543642438281030999784255232f,
          -0.8200019859739029219539498726697452080761f,
          0.8200019859739029219539498726697452080761f,
          -0.8864155270044010342131543419821967550873f,
          0.8864155270044010342131543419821967550873f,
          -0.9382745520027327585236490017087214496548f,
          0.9382745520027327585236490017087214496548f,
          -0.9747285559713094981983919930081690617411f,
          0.9747285559713094981983919930081690617411f,
          -0.9951872199970213601799974097007368118745f,
          0.9951872199970213601799974097007368118745f
        };

        // Legendre-Gauss weights with n=24 (w_i values, defined by a function linked to in the Bezier primer article)
        private static readonly float[] Cvalues = new[] {
      0.1279381953467521569740561652246953718517f,
      0.1279381953467521569740561652246953718517f,
      0.1258374563468282961213753825111836887264f,
      0.1258374563468282961213753825111836887264f,
      0.121670472927803391204463153476262425607f,
      0.121670472927803391204463153476262425607f,
      0.1155056680537256013533444839067835598622f,
      0.1155056680537256013533444839067835598622f,
      0.1074442701159656347825773424466062227946f,
      0.1074442701159656347825773424466062227946f,
      0.0976186521041138882698806644642471544279f,
      0.0976186521041138882698806644642471544279f,
      0.086190161531953275917185202983742667185f,
      0.086190161531953275917185202983742667185f,
      0.0733464814110803057340336152531165181193f,
      0.0733464814110803057340336152531165181193f,
      0.0592985849154367807463677585001085845412f,
      0.0592985849154367807463677585001085845412f,
      0.0442774388174198061686027482113382288593f,
      0.0442774388174198061686027482113382288593f,
      0.0285313886289336631813078159518782864491f,
      0.0285313886289336631813078159518782864491f,
      0.0123412297999871995468056670700372915759f,
      0.0123412297999871995468056670700372915759f
    };
        private static float sqrt(float v)
        {
            return (float)Math.Sqrt(v);
        }
        private static float abs(float v)
        {
            return (float)Math.Abs(v);
        }

        private static float pow(float a, float b)
        {
            return (float)Math.Pow(a, b);
        }

        // cube root function yielding real roots
        private static float crt(float v)
        {
            return v < 0 ? -pow(-v, 1F / 3) : pow(v, 1F / 3);
        }

        // trig constants
        const float pi = 3.1415926535897931f;
        const float tau = 2 * pi;
        const float quart = pi / 2;

        private static float acos(float v)
        {
            return (float)Math.Acos(v);
        }
        private static float cos(float v)
        {
            return (float)Math.Cos(v);
        }

        private static float sin(float v)
        {
            return (float)Math.Sin(v);
        }

        private static float atan2(float y, float x)
        {
            return (float)Math.Atan2(y, x);
        }

        public static float arcfn(float t, Func<float, Vector2> derivativeFn)
        {
            Vector2 d = derivativeFn(t);

            return d.Length();
        }

        public static float angle(Vector2 o, Vector2 v1, Vector2 v2)
        {
            var dx1 = v1.X - o.X;
            var dy1 = v1.Y - o.Y;
            var dx2 = v2.X - o.X;
            var dy2 = v2.Y - o.Y;
            var cross = dx1 * dy2 - dy1 * dx2;
            var dot = dx1 * dx2 + dy1 * dy2;
            return atan2(cross, dot);
        }


        public static bool between(float v, float m, float M)
        {
            return (
              (m <= v && v <= M) ||
              Approximately(v, m) ||
              Approximately(v, M)
            );
        }

        public static bool Approximately(float a, float b, float precision = epsilon)
        {
            return Math.Abs(a - b) <= precision;
        }

        public static float Length(Func<float, Vector2> derivativeFn)
        {
            var z = 0.5f;
            var sum = 0f;

            var len = Tvalues.Length;

            for (var i = 0; i < len; i++)
            {
                var t = z * Tvalues[i] + z;
                sum += Cvalues[i] * arcfn(t, derivativeFn);
            }
            return z * sum;
        }

        public static float Map(float v, float ds, float de, float ts, float te)
        {
            var d1 = de - ds;
            var d2 = te - ts;
            var v2 = v - ds;
            var r = v2 / d1;
            return ts + d2 * r;
        }

        public static Vector2 Lerp(float r, Vector2 v1, Vector2 v2)
        {
            return Vector2.Lerp(v1, v2, r);
        }

        public static float Angle(Vector2 o, Vector2 v1, Vector2 v2)
        {
            var dx1 = v1.X - o.X;
            var dy1 = v1.Y - o.Y;
            var dx2 = v2.X - o.X;
            var dy2 = v2.Y - o.Y;
            var cross = dx1 * dy2 - dy1 * dx2;
            var dot = dx1 * dx2 + dy1 * dy2;

            return (float)Math.Atan2(cross, dot);
        }

        public static void Closest(IEnumerable<Vector2> LUT, Vector2 point, out float mdist, out int mpos)
        {
            int idx = 0;
            mdist = float.MaxValue;
            mpos = -1;

            foreach (var p in LUT)
            {
                var d = Vector2.Distance(point, p);
                if (d < mdist)
                {
                    mdist = d;
                    mpos = idx;
                }
            }
        }

        public static float? abcratio(float t, int n)
        {
            // see ratio(t) note on http://pomax.github.io/bezierinfo/#abc
            if (n != 2 && n != 3)
            {
                return null;
            }

            //if (typeof t == "undefined")
            //{
            //    t = 0.5f;
            //}
            //else
            if (t == 0 || t == 1)
            {
                return t;
            }

            var bottom = Math.Pow(t, n) + Math.Pow(1 - t, n);
            var top = bottom - 1;
            return (float)Math.Abs(top / bottom);
        }

        public static float? projectionratio(float t, int n)
        {
            // see u(t) note on http://pomax.github.io/bezierinfo/#abc
            if (n != 2 && n != 3)
            {
                return null;
            }
            //if (typeof t == "undefined")
            //{
            //    t = 0.5;
            //}
            //else
            if (t == 0 || t == 1)
            {
                return t;
            }

            var top = Math.Pow(1 - t, n);
            var bottom = Math.Pow(t, n) + top;
            return (float)(top / bottom);
        }

        public static Vector2? Lli8(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
            var nx =
                (x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4);
            var ny = (x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4);
            var d = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
            if (d == 0)
            {
                return null;
            }
            return new Vector2(x: nx / d, y: ny / d);
        }

        public static Vector2? Lli4(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
        {
            var x1 = p1.X;
            var y1 = p1.Y;
            var x2 = p2.X;
            var y2 = p2.Y;
            var x3 = p3.X;
            var y3 = p3.Y;
            var x4 = p4.X;
            var y4 = p4.Y;

            return Lli8(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        //public static Vector2? Lli(dynamic v1, dynamic v2)
        //{
        //    return Lli4(v1, v1.c, v2, v2.c);
        //}


        public static Bezier makeline(Vector2 p1, Vector2 p2)
        {
            var x1 = p1.X;
            var y1 = p1.Y;
            var x2 = p2.X;
            var y2 = p2.Y;

            var dx = (x2 - x1) / 3;
            var dy = (y2 - y1) / 3;

            return new Bezier(p1, new Vector2(x1 + dx, y1 + dy), new Vector2(x1 + 2 * dx, y1 + 2 * dy), p2);
        }

        //findbbox: function(sections) {
        //  var mx = nMax,
        //    my = nMax,
        //    MX = nMin,
        //    MY = nMin;
        //  sections.forEach(function(s) {
        //    var bbox = s.bbox();
        //    if (mx > bbox.x.min) mx = bbox.x.min;
        //    if (my > bbox.y.min) my = bbox.y.min;
        //    if (MX < bbox.x.max) MX = bbox.x.max;
        //    if (MY < bbox.y.max) MY = bbox.y.max;
        //  });
        //  return {
        //    x: { min: mx, mid: (mx + MX) / 2, max: MX, size: MX - mx },
        //    y: { min: my, mid: (my + MY) / 2, max: MY, size: MY - my }
        //  };
        //},

        //shapeintersections: function(
        //  s1,
        //  bbox1,
        //  s2,
        //  bbox2,
        //  curveIntersectionThreshold
        //) {
        //  if (!utils.bboxoverlap(bbox1, bbox2)) return [];
        //  var intersections = [];
        //  var a1 = [s1.startcap, s1.forward, s1.back, s1.endcap];
        //  var a2 = [s2.startcap, s2.forward, s2.back, s2.endcap];
        //  a1.forEach(function(l1) {
        //    if (l1.virtual) return;
        //    a2.forEach(function(l2) {
        //      if (l2.virtual) return;
        //      var iss = l1.intersects(l2, curveIntersectionThreshold);
        //      if (iss.length > 0) {
        //        iss.c1 = l1;
        //        iss.c2 = l2;
        //        iss.s1 = s1;
        //        iss.s2 = s2;
        //        intersections.push(iss);
        //      }
        //    });
        //  });
        //  return intersections;
        //},

        //makeshape: function(forward, back, curveIntersectionThreshold) {
        //  var bpl = back.points.length;
        //  var fpl = forward.points.length;
        //  var start = utils.makeline(back.points[bpl - 1], forward.points[0]);
        //  var end = utils.makeline(forward.points[fpl - 1], back.points[0]);
        //  var shape = {
        //    startcap: start,
        //    forward: forward,
        //    back: back,
        //    endcap: end,
        //    bbox: utils.findbbox([start, forward, back, end])
        //  };
        //  var self = utils;
        //  shape.intersections = function(s2) {
        //    return self.shapeintersections(
        //      shape,
        //      shape.bbox,
        //      s2,
        //      s2.bbox,
        //      curveIntersectionThreshold
        //    );
        //  };
        //  return shape;
        //},

        public static void GetMinMaxX(Bezier curve, float[] list, out float min, out float max)
        {
            min = 0;
            max = 0;

            if (list == null) return;


            var list1 = new List<float>(list);
            min = float.PositiveInfinity;
            max = float.NegativeInfinity;


            if (list1.IndexOf(0) == -1)
            {
                list1.Insert(0, 0);
            }
            if (list1.IndexOf(1) == -1)
            {
                list1.Add(1);
            }
            for (var i = 0; i < list1.Count; i++)
            {
                var t = list1[i];
                var c = curve.Position(t);

                if (c.X < min)
                {
                    min = c.X;
                }
                if (c.X > max)
                {
                    max = c.X;
                }
            }
        }

        public static void GetMinMaxY(Bezier curve, float[] list, out float min, out float max)
        {
            min = 0;
            max = 0;

            if (list == null) return;


            var list1 = new List<float>(list);
            min = float.PositiveInfinity;
            max = float.NegativeInfinity;


            if (list1.IndexOf(0) == -1)
            {
                list1.Insert(0, 0);
            }
            if (list1.IndexOf(1) == -1)
            {
                list1.Add(1);
            }
            for (var i = 0; i < list1.Count; i++)
            {
                var t = list1[i];
                var c = curve.Position(t);

                if (c.Y < min)
                {
                    min = c.Y;
                }
                if (c.Y > max)
                {
                    max = c.Y;
                }
            }
        }

        public static IEnumerable<Vector2> Align(IEnumerable<Vector2> points, Line line)
        {
            var tx = line.P1.X;
            var ty = line.P1.Y;
            var a = -atan2(line.P2.Y - ty, line.P2.X - tx);

            //Vector2 d(Vector2 v)
            //{
            //    return new Vector2(x: (v.X - tx) * cos(a) - (v.Y - ty) * sin(a), y: (v.X - tx) * sin(a) + (v.Y - ty) * cos(a));
            //}
            var alignedPoints= points.Select(v=> new Vector2(x: (v.X - tx) * cos(a) - (v.Y - ty) * sin(a), y: (v.X - tx) * sin(a) + (v.Y - ty) * cos(a))).ToArray();

            return alignedPoints;
        }

        public static float[] Roots(Vector2[] points)
        {
            return Roots(points, new Line { P1 = Vector2.Zero, P2 = Vector2.UnitX });
        }

        public static float[] Roots(Vector2[] points, Line line)
        {
            var order = points.Length - 1;
            var p = Align(points, line).ToArray();

            bool reduce(float t)
            {
                return 0 <= t && t <= 1;
            }

            if (order == 2)
            {
                var a = p[0].Y;
                var b = p[1].Y;
                var c = p[2].Y;
                var d = a - 2 * b + c;
                if (d != 0)
                {
                    var m1 = -sqrt(b * b - a * c);
                    var m2 = -a + b;
                    var v1 = -(m1 + m2) / d;
                    var v2 = -(-m1 + m2) / d;

                    return new[] { v1, v2 }.Where(reduce).ToArray();

                }
                else if (b != c && d == 0)
                {
                    return new[] { (2 * b - c) / (2 * (b - c)) }.Where(reduce).ToArray();
                }
                return new float[0];
            }
            {
                // see http://www.trans4mind.com/personal_development/mathematics/polynomials/cubicAlgebra.htm
                var pa = p[0].Y;
                var pb = p[1].Y;
                var pc = p[2].Y;
                var pd = p[3].Y;

                var d = -pa + 3 * pb - 3 * pc + pd;
                var a = 3 * pa - 6 * pb + 3 * pc;
                var b = -3 * pa + 3 * pb;
                var c = pa;

                if (Approximately(d, 0))
                {
                    // this is not a cubic curve.
                    if (Approximately(a, 0))
                    {
                        // in fact, this is not a quadratic curve either.
                        if (Approximately(b, 0))
                        {
                            // in fact in fact, there are no solutions.
                            return new float[0];
                        }
                        // linear solution:
                        return new[] { -c / b }.Where(reduce).ToArray();
                    }

                    // quadratic solution:
                    var qq = sqrt(b * b - 4 * a * c);
                    var a2 = 2 * a;
                    return new[] { (qq - b) / a2, (-b - qq) / a2 }.Where(reduce).ToArray();
                }


                // at this point, we know we need a cubic solution:

                a /= d;
                b /= d;
                c /= d;


                var pp = (3 * b - a * a) / 3;
                var p3 = pp / 3;
                var q = (2 * a * a * a - 9 * a * b + 27 * c) / 27;
                var q2 = q / 2;
                var discriminant = q2 * q2 + p3 * p3 * p3;


                if (discriminant < 0)
                {
                    var mp3 = -pp / 3;
                    var mp33 = mp3 * mp3 * mp3;
                    var r = sqrt(mp33);
                    var t = -q / (2 * r);
                    var cosphi = t < -1 ? -1 : t > 1 ? 1 : t;
                    var phi = acos(cosphi);
                    var crtr = crt(r);
                    var t1 = 2 * crtr;
                    var x1 = t1 * cos(phi / 3) - a / 3;
                    var x2 = t1 * cos((phi + tau) / 3) - a / 3;
                    var x3 = t1 * cos((phi + 2 * tau) / 3) - a / 3;
                    return new[] { x1, x2, x3 }.Where(reduce).ToArray();
                }
                else if (discriminant == 0)
                {
                    var u1 = q2 < 0 ? crt(-q2) : -crt(q2);
                    var x1 = 2 * u1 - a / 3;
                    var x2 = -u1 - a / 3;
                    return new[] { x1, x2 }.Where(reduce).ToArray();
                }
                else
                {
                    var sd = sqrt(discriminant);
                    var u1 = crt(-q2 + sd);
                    var v1 = crt(q2 + sd);
                    return new[] { u1 - v1 - a / 3 }.Where(reduce).ToArray();
                }
            }
        }

        public static float[] droots(float[] p)
        {
            // quadratic roots are easy
            if (p.Length == 3)
            {
                var a = p[0];
                var b = p[1];
                var c = p[2];
                var d = a - 2 * b + c;
                if (d != 0)
                {
                    var m1 = -sqrt(b * b - a * c);
                    var m2 = -a + b;
                    var v1 = -(m1 + m2) / d;
                    var v2 = -(-m1 + m2) / d;
                    return new[] { v1, v2 };
                }
                else if (b != c && d == 0)
                {
                    return new[] { (2 * b - c) / (2 * (b - c)) };
                }
                return new float[0];
            }

            // linear roots are even easier
            if (p.Length == 2)
            {
                var a = p[0];
                var b = p[1];
                if (a != b)
                {
                    return new[] { a / (a - b) };
                }
                return new float[0];
            }

            return new float[0];

        }

        public static float[] Inflections(Vector2[] points)
        {
            if (points.Length < 4) return new float[0];

            //  // FIXME: TODO: add in inflection abstraction for quartic+ curves?

            var p = Utils.Align(points, new Line { P1 = points[0], P2 = points.Last() }).ToArray();

            var a = p[2].X * p[1].Y;
            var b = p[3].X * p[1].Y;
            var c = p[1].X * p[2].Y;
            var d = p[3].X * p[2].Y;

            var v1 = 18 * (-3 * a + 2 * b + 3 * c - d);
            var v2 = 18 * (3 * a - b - 3 * c);
            var v3 = 18 * (c - a);

            if (Utils.Approximately(v1, 0))
            {
                if (!Utils.Approximately(v2, 0))
                {
                    var t = -v3 / v2;
                    if (0 <= t && t <= 1) return new[] { t };
                }
                return new float[0];
            }

            var trm = v2 * v2 - 4 * v1 * v3;
            var sq = (float)Math.Sqrt(trm);
            var dd = 2 * v1;

            if (Utils.Approximately(dd, 0)) return new float[0];

            return new[] { (sq - v2) / dd, -(v2 + sq) / dd }.Where((r) =>
            {
                return 0 <= r && r <= 1;
            }).ToArray();
        }


        public static List<Pair<float>> PairIteration(Bezier c1, Bezier c2, float threshold)
        {
            var c1b = c1.BoundingBox;
            var c2b = c2.BoundingBox;

            var r = 100000;

            if (c1b.Width + c1b.Height < threshold && c2b.Width + c2b.Height < threshold)
            {
                return new List<Pair<float>> { new Pair<float>(((r * (c1._t1 + c1._t2) / 2)) / r, ((r * (c2._t1 + c2._t2) / 2)) / r) };
            }

            var cc1 = c1.Split(0.5f);
            var cc2 = c2.Split(0.5f);

            var pairs = new Pair<Bezier>[] {
                new Pair<Bezier>(cc1.Left, cc2.Left),
                new Pair<Bezier>(cc1.Left, cc2.Right),
                new Pair<Bezier>(cc1.Right, cc2.Right),
                new Pair<Bezier>(cc1.Right, cc2.Left)
            };

            pairs = pairs.Where((pair) =>
            {
                return BoundingBox.Intersects(pair.Left.BoundingBox, pair.Right.BoundingBox);
            }).ToArray();

            var results = new List<Pair<float>>();

            if (pairs.Length == 0) return results;

            foreach (var pair in pairs)
            {
                results.AddRange(Utils.PairIteration(pair.Left, pair.Right, threshold));
            }

            return results.Distinct(new Pair<float>.EqualityComparer()).ToList();
        }

        public static Arc Getccenter(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            var dx1 = p2.X - p1.X;
            var dy1 = p2.Y - p1.Y;
            var dx2 = p3.X - p2.X;
            var dy2 = p3.Y - p2.Y;
            var dx1p = dx1 * cos(quart) - dy1 * sin(quart);
            var dy1p = dx1 * sin(quart) + dy1 * cos(quart);
            var dx2p = dx2 * cos(quart) - dy2 * sin(quart);
            var dy2p = dx2 * sin(quart) + dy2 * cos(quart);
            // chord midpoints
            var mx1 = (p1.X + p2.X) / 2;
            var my1 = (p1.Y + p2.Y) / 2;
            var mx2 = (p2.X + p3.X) / 2;
            var my2 = (p2.Y + p3.Y) / 2;
            // midpoint offsets
            var mx1n = mx1 + dx1p;
            var my1n = my1 + dy1p;
            var mx2n = mx2 + dx2p;
            var my2n = my2 + dy2p;
            //  // intersection of these lines:
            var arc = Utils.Lli8(mx1, my1, mx1n, my1n, mx2, my2, mx2n, my2n).Value;
            var r = Vector2.Distance(arc, p1);
            // arc start/end values, over mid point:
            var s = atan2(p1.Y - arc.Y, p1.X - arc.X);
            var m = atan2(p2.Y - arc.Y, p2.X - arc.X);
            var e = atan2(p3.Y - arc.Y, p3.X - arc.X);
            //    _;
            // determine arc direction (cw/ccw correction)
            if (s < e)
            {
                // if s<m<e, arc(s, e)
                // if m<s<e, arc(e, s + tau)
                // if s<e<m, arc(e, s + tau)
                if (s > m || m > e)
                {
                    s += tau;
                }
                if (s > e)
                {
                    var _ = e;
                    e = s;
                    s = _;
                }
            }
            else
            {
                // if e<m<s, arc(e, s)
                // if m<e<s, arc(s, e + tau)
                // if e<s<m, arc(s, e + tau)
                if (e < m && m < s)
                {
                    var _ = e;
                    e = s;
                    s = _;
                }
                else
                {
                    e += tau;
                }
            }
            // assign and done.

            return new Arc
            {
                Center = arc,
                StartAngle = s,
                EndAngle = e,
                Radius = r
            };
        }

        public static int NumberSort(float a, float b)
        {
            return Math.Sign(a - b);
        }
    }
}