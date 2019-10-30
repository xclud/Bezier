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
    public partial class CombinedBezierPartDemoControl : UserControl
    {
        public CombinedBezierPartDemoControl()
        {
            InitializeComponent();
            QuadraticBezierPartDemoControl.Bezier = new Bezier(((double)QuadraticBezierPartDemoControl.Width * 0.3D), ((double)QuadraticBezierPartDemoControl.Height * 0.7D), ((double)QuadraticBezierPartDemoControl.Width * 0.5D), ((double)QuadraticBezierPartDemoControl.Height * 0.1D), ((double)QuadraticBezierPartDemoControl.Width * 0.9D), ((double)QuadraticBezierPartDemoControl.Height * 0.6D)); ;
            CubicBezierPartDemoControl.Bezier = new Bezier(((double)CubicBezierPartDemoControl.Width * 0.1D), ((double)CubicBezierPartDemoControl.Height * 0.8D), ((double)CubicBezierPartDemoControl.Width * 0.2D), ((double)CubicBezierPartDemoControl.Height * 0.1D), ((double)CubicBezierPartDemoControl.Width * 0.8D), ((double)CubicBezierPartDemoControl.Height * 0.9D), ((double)CubicBezierPartDemoControl.Width * 0.9D), ((double)CubicBezierPartDemoControl.Height * 0.2D));
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
