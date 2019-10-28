using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.DoubleNumerics;
using System.Text;

namespace System.Geometry_Test
{

    [TestClass]
    public class BezierTest
    {
        [TestMethod]
        public void LineIntersectVerticalTest1()
        {
            Bezier B = GetTestBezier2();

            bool ok = true;
            List<double> failedPositions = new List<double>();

            BoundingBox BB = B.BoundingBox;

            for (double x = BB.Min.X+0.00001; x <= BB.Max.X; x++)
            {
                Line L = new Line(new Vector2(x, BB.Min.Y), new Vector2(x, BB.Max.Y));

                var result = B.Intersects(L);

                if(result.Length!=1)
                {
                    ok = false;
                    failedPositions.Add(x);

                } 
            }
           

            Assert.IsTrue(ok,string.Join(", ",failedPositions));
        }

        [TestMethod]
        public void LineIntersectHorizontalTest1()
        {
            Bezier B = GetTestBezier2();
            bool ok = true;
            List<double> failedPositions = new List<double>();
            BoundingBox BB = B.BoundingBox;
            for (double y = BB.Min.Y+0.00001; y <= BB.Max.Y; y++)
            {
                Line L = new Line(new Vector2(BB.Min.X,y), new Vector2(BB.Max.X,y));

                var result = B.Intersects(L);

                if (result.Length != 1)
                {
                    ok = false;
                    failedPositions.Add(y);

                }
            }


            Assert.IsTrue(ok, string.Join(", ", failedPositions));
        }





        private Bezier GetTestBezier()
        {
            Bezier B = new Bezier(new Vector2(0, 0), new Vector2(50, 100), new Vector2(150, 100), new Vector2(200, 200));
            return B;
        }

        private Bezier GetTestBezier2()
        {
            Point start = new Point(0, 0);
            Point control1 = new Point(100, 200);
            Point control2 = new Point(350, 100);
            Point end1 = new Point(800, 200);

            //Point start = new Point(0, 0);
            //Point control1 = new Point(50, 100);
            //Point control2 = new Point(150, 100);
            //Point end1 = new Point(200, 200);
            Bezier B = new Bezier(PointToVector2(start), PointToVector2(control1), PointToVector2(control2), PointToVector2(end1));
            return B;
        }

        private Vector2 PointToVector2(Point Source)
        {
            return new Vector2(Source.X, Source.Y);
        }

    }
}
