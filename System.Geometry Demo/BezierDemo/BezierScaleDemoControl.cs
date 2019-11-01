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
    public class BezierScaleDemoControl : BezierDemoControl
    {
        public BezierScaleDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int d = -30 ; d <= 30; d+=10)
            {
                Bezier scaledbezier = Bezier.Scale(d);
                if (scaledbezier != null) DrawBezier(e.Graphics, scaledbezier.Points, Color.Red, 1);
            }


        }


    }
}
