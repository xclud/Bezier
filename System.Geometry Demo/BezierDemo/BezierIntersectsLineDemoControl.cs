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
    public class BezierIntersectsLineDemoControl : BezierDemoControl
    {
        public BezierIntersectsLineDemoControl(): base() {
            Bezier = new Bezier(((double)Width *0.1D),((double)Height*0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Line line = new Line(new Vector2(0, (double)Height * 0.75), new Vector2(Width, (double)this.Height * 0.25));

            using (Pen linePen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawLine(linePen, Vector2ToPointF(line.P1), Vector2ToPointF(line.P2));
            }

            foreach (double t in Bezier.Intersects(line))
            {
                DrawPoint(e.Graphics, Bezier.Position(t), Color.Blue, 10);
            } 



        }



    }
}
