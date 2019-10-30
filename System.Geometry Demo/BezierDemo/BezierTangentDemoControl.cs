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
    public class BezierTangentDemoControl : BezierDemoControl
    {
        public BezierTangentDemoControl(): base() {
            Bezier = new Bezier(((double)Width *0.1D),((double)Height*0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (double t = 0; t <= 1; t+=0.1)
            {
                Vector2 pt = Bezier.Position(t);
                Vector2 dv = Bezier.Tangent(t);
                DrawLine(e.Graphics, pt, pt + dv,Color.Red, 1);
            }

        }


    }
}
