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
    public class BezierAlignDemoControl : BezierDemoControl
    {
        public BezierAlignDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Line line = new Line(new Vector2(0,0), new Vector2((double)Width , (double)this.Height));
            Bezier alignedBezier = Bezier.Align(line);
            Vector2 offset = new Vector2((double)Width / 2, (double)Height / 2)-(alignedBezier.BoundingBox.Min + ((alignedBezier.BoundingBox.Max - alignedBezier.BoundingBox.Min) / 2));
            alignedBezier.Move(offset);
            DrawLine(e.Graphics, line.P1, line.P2, Color.Red, 1);
            DrawBezier(e.Graphics, alignedBezier.Points, Color.Green, 1);
            DrawHandles(e.Graphics, alignedBezier.Points, Color.LightBlue, 10, 1, Color.LightBlue, 1);

            
        }


    }
}
