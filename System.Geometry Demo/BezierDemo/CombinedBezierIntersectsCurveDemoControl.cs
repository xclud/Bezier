using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Geometry;

namespace System.Geometry_Demo.BezierDemo
{
    public partial class CombinedBezierIntersectsCurveDemoControl : UserControl
    {
        public CombinedBezierIntersectsCurveDemoControl()
        {
            InitializeComponent();
            QuadraticCurveIntersectsControl.Bezier = new Bezier(((double)QuadraticCurveIntersectsControl.Width * 0.3D), ((double)QuadraticCurveIntersectsControl.Height * 0.1D), ((double)QuadraticCurveIntersectsControl.Width * 0.6D), ((double)QuadraticCurveIntersectsControl.Height * 0.9D), ((double)QuadraticCurveIntersectsControl.Width * 0.9D), ((double)QuadraticCurveIntersectsControl.Height * 0.2D)); ;
            CubicCurveIntersectsControl.Bezier = new Bezier(((double)CubicCurveIntersectsControl.Width * 0.1D), ((double)CubicCurveIntersectsControl.Height * 0.8D), ((double)CubicCurveIntersectsControl.Width * 0.2D), ((double)CubicCurveIntersectsControl.Height * 0.1D), ((double)CubicCurveIntersectsControl.Width * 0.8D), ((double)CubicCurveIntersectsControl.Height * 0.9D), ((double)CubicCurveIntersectsControl.Width * 0.9D), ((double)CubicCurveIntersectsControl.Height * 0.2D));
       }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
