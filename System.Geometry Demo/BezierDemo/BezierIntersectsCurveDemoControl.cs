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
    public class BezierIntersectsCurveDemoControl : BezierDemoControl
    {
        public BezierIntersectsCurveDemoControl(): base() {
            Bezier = new Bezier(((double)Width *0.1D),((double)Height*0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.7D), ((double)Height * 0.4D));
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Bezier curve = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.25D), ((double)Height * 0.1D), ((double)Width * 0.7D), ((double)Height * 0.15D), ((double)Width * 0.9D), ((double)Height * 0.9D));

            using (Pen linePen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawBeziers(linePen,curve.Points.Select(p=>Vector2ToPointF(p)).ToArray());
            }

            List<Pair<double>> intersections = Bezier.Intersects(curve,0.1);
            foreach (Pair<double> pair in intersections)
            {
                DrawPoint(e.Graphics, Bezier.Position(pair.Left), Color.Blue, 10);
            }

        }



    }
}
