using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Numerics;
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
            List<int> failedPositions = new List<int>();

            for (int x = 1; x <= B.Points.Last().X; x++)
            {
                Line L = new Line(new Vector2(x, 0), new Vector2(x, 1000));

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
            List<int> failedPositions = new List<int>();

            for (int y = 1; y <= B.Points.Last().X; y++)
            {
                Line L = new Line(new Vector2(0,y), new Vector2(1000,y));

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
            Point control1 = new Point(100, 500);
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
