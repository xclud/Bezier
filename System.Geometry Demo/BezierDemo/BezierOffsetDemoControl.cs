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
    public class BezierOffsetDemoControl : BezierDemoControl
    {
        public BezierOffsetDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            List<Bezier> curves =  Bezier.Offset(20);
            foreach (Bezier bezier in curves)
            {
                DrawBezier(e.Graphics,bezier.Points,Color.Red,1);
                DrawHandles(e.Graphics, bezier.Points, Color.LightGreen, 10, 1, Color.LightGreen, 1);
            }

            DrawPoint(e.Graphics, Bezier.Offset(0.5, -20), Color.Blue, 10);
            DrawPoint(e.Graphics, Bezier.Offset(0.2, -20), Color.Yellow, 10);
            DrawPoint(e.Graphics, Bezier.Offset(0.7, -20), Color.Pink, 10);

        }


    }
}
