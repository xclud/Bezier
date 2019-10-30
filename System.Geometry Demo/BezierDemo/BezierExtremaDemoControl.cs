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
    public class BezierExtremaDemoControl : BezierDemoControl
    {
        public BezierExtremaDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Extrema extrema = Bezier.Extrema();
            for (int i = 0; i < extrema.X.Length; i++)
            {
                DrawPoint(e.Graphics, Bezier.Position(extrema.Values[i]), Color.Blue, 10);
            }

        }


    }
}
