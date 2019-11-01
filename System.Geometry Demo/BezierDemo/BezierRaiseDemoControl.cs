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
    public class BezierRaiseDemoControl : BezierDemoControl
    {
        public BezierRaiseDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D),  ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Bezier raisedBezier = Bezier.Raise();

            DrawBezier(e.Graphics, raisedBezier.Points, Color.Red, 2);
            DrawHandles(e.Graphics, raisedBezier.Points, Color.Blue, 10, 1, Color.Blue, 2);

            
        }


    }
}
