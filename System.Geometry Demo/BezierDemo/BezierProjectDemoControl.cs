using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DoubleNumerics;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Geometry_Demo.BezierDemo
{
    public class BezierProjectDemoControl : BezierLUTDemoControl
    {
        public BezierProjectDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        Vector2 mousePos = Vector2.Zero;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Vector2 point = Bezier.Project( mousePos, out double t, out double d);
            DrawLine(e.Graphics,mousePos,point,Color.Red,1);
            DrawPoint(e.Graphics, point, Color.Green, 10);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           

            mousePos = PointToVector2(e.Location);
            base.OnMouseMove(e);
            Invalidate();
        }

   


    }
}
