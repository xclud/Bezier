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
    public class BezierSplitAtPointDemoControl : BezierDemoControl
    {
        public BezierSplitAtPointDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        Vector2 mousePos = Vector2.Zero;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Split split = Bezier.SplitAtPoint(mousePos,150);
            if (split != null)
            {
                DrawBezier(e.Graphics, split.Left.Points, Color.Red, BezierWidth);
                DrawBezier(e.Graphics, split.Right.Points, Color.Green, BezierWidth);
                DrawPoint(e.Graphics, split.Left.Points.Last(), Color.Green, 10);
                DrawLine(e.Graphics, mousePos, split.Left.Points.Last(), Color.Red, 1);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {


            mousePos = PointToVector2(e.Location);
            base.OnMouseMove(e);
            Invalidate();
        }

    }
}
