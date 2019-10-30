using System;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Geometry_Demo.BezierDemo
{
    public class BezierSplitDemoControl : BezierDemoControl
    {
        public BezierSplitDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            double splitPos = 0.5;
            Split s =  Bezier.Split(splitPos);

            DrawBezier(e.Graphics, s.Left.Points, Color.Red, BezierWidth);

            DrawHandles(e.Graphics, s.Left.Points, Color.Green, 10, 1, Color.Green, 1);
            DrawHandles(e.Graphics, s.Right.Points, Color.Blue, 10, 1, Color.Blue, 1);

            DrawPoint(e.Graphics,Bezier.Position(splitPos),Color.Blue,10);

        }


    }
}
