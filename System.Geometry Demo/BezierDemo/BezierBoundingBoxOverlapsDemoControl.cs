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
    public class BezierBoundingBoxOverlapsDemoControl : BezierDemoControl
    {
        public BezierBoundingBoxOverlapsDemoControl(): base() {
            Bezier = new Bezier(((double)Width *0.1D),((double)Height*0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.7D), ((double)Height * 0.4D));
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Bezier curve = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.25D), ((double)Height * 0.1D), ((double)Width * 0.7D), ((double)Height * 0.15D), ((double)Width * 0.9D), ((double)Height * 0.9D));

            

            var bb1 = Bezier.BoundingBox;
            DrawRectangle(e.Graphics, bb1.Min, bb1.Max, Color.Blue, 1);
            var bb2 = curve.BoundingBox;
            DrawRectangle(e.Graphics, bb2.Min, bb2.Max, Color.Yellow, 1);
            bool overlaps = Bezier.BoundingBoxOverlaps(curve);
            using (Pen linePen = new Pen((overlaps?Color.Green:Color.Red), 2))
            {
                e.Graphics.DrawBeziers(linePen,curve.Points.Select(p=>Vector2ToPointF(p)).ToArray());
            }



        }



    }
}
