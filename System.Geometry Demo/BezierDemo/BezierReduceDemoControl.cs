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
    public class BezierReduceDemoControl : BezierDemoControl
    {
        public BezierReduceDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            List<Bezier> reduced=Bezier.Reduce();
            Color[] colors = { Color.Red, Color.Green, Color.Yellow }; int colorIndex = 0;
            foreach (Bezier bezier in reduced)
            {
                DrawBezier(e.Graphics, bezier.Points, colors[colorIndex], BezierWidth+1);
                DrawHandles(e.Graphics, bezier.Points, Color.Blue, 10, 1, Color.LightBlue, 1);
                colorIndex = (colorIndex + 1) % colors.Length;
            }
            DrawText(e.Graphics, $"{reduced.Count} curves", new Vector2(10, 10), Color.Black, 20);


        }


    }
}
