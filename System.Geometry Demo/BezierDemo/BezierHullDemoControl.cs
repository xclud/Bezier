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
    public class BezierHullDemoControl : BezierDemoControl
    {
        public BezierHullDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            List<Vector2> hull = Bezier.Hull(0.5);
            DrawHull(e.Graphics,hull,Color.Red);
            DrawPoint(e.Graphics, hull.Last(), Color.Blue, 10);
            
        }

        private void DrawHull(Graphics gfx, List<Vector2> hull, Color hullColor)
        {
            if (hull.Count == 6)
            {
                DrawLine(gfx, hull[0], hull[1], hullColor, 1);
                DrawLine(gfx, hull[1], hull[2], hullColor, 1);

                DrawLine(gfx, hull[3], hull[4], hullColor, 1);
            }
            else
            {
                DrawLine(gfx, hull[0], hull[1], hullColor, 1);
                DrawLine(gfx, hull[1], hull[2], hullColor, 1);
                DrawLine(gfx, hull[2], hull[3], hullColor, 1);

                DrawLine(gfx, hull[4], hull[5], hullColor, 1);
                DrawLine(gfx, hull[5], hull[6], hullColor, 1);

                DrawLine(gfx, hull[7], hull[8], hullColor, 1);
            }
        }


    }
}
