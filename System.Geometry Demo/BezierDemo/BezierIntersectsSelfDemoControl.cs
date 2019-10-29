using System;
using System.Collections.Generic;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Geometry_Demo.BezierDemo
{
    public class BezierIntersectsSelfDemoControl : BezierDemoControl
    {
        public BezierIntersectsSelfDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width/200*100), ((double)Height/200*25), ((double)Width / 200 * 10), ((double)Height / 200*180), ((double)Width / 120 * 170), ((double)Height / 200 * 165), ((double)200 / 120 * 65), ((double)Height / 200 * 70));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            List<Pair<double>> intersections = Bezier.IntersectsWithSelf(0.1);
            foreach (Pair<double> pair in intersections)
            {
                DrawPoint(e.Graphics, Bezier.Position(pair.Left), Color.Blue, 10);
            }

            
        }
    }
}
