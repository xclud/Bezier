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
    public partial class CombinedBezierTangentDemoControl : UserControl
    {
        public CombinedBezierTangentDemoControl()
        {
            InitializeComponent();
            QuadraticBezierTangentDemoControl.Bezier = new Bezier(((double)QuadraticBezierTangentDemoControl.Width * 0.3D), ((double)QuadraticBezierTangentDemoControl.Height * 0.7D), ((double)QuadraticBezierTangentDemoControl.Width * 0.5D), ((double)QuadraticBezierTangentDemoControl.Height * 0.1D), ((double)QuadraticBezierTangentDemoControl.Width * 0.9D), ((double)QuadraticBezierTangentDemoControl.Height * 0.6D)); ;
            CubicBezierTangentDemoControl.Bezier = new Bezier(((double)CubicBezierTangentDemoControl.Width * 0.1D), ((double)CubicBezierTangentDemoControl.Height * 0.8D), ((double)CubicBezierTangentDemoControl.Width * 0.2D), ((double)CubicBezierTangentDemoControl.Height * 0.1D), ((double)CubicBezierTangentDemoControl.Width * 0.8D), ((double)CubicBezierTangentDemoControl.Height * 0.9D), ((double)CubicBezierTangentDemoControl.Width * 0.9D), ((double)CubicBezierTangentDemoControl.Height * 0.2D));
             }

            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
