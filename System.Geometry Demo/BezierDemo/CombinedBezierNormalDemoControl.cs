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
    public partial class CombinedBezierNormalDemoControl : UserControl
    {
        public CombinedBezierNormalDemoControl()
        {
            InitializeComponent();
            QuadraticBezierNormalDemoControl.Bezier = new Bezier(((double)QuadraticBezierNormalDemoControl.Width * 0.3D), ((double)QuadraticBezierNormalDemoControl.Height * 0.7D), ((double)QuadraticBezierNormalDemoControl.Width * 0.5D), ((double)QuadraticBezierNormalDemoControl.Height * 0.1D), ((double)QuadraticBezierNormalDemoControl.Width * 0.9D), ((double)QuadraticBezierNormalDemoControl.Height * 0.6D)); ;
            CubicBezierNormalDemoControl.Bezier = new Bezier(((double)CubicBezierNormalDemoControl.Width * 0.1D), ((double)CubicBezierNormalDemoControl.Height * 0.8D), ((double)CubicBezierNormalDemoControl.Width * 0.2D), ((double)CubicBezierNormalDemoControl.Height * 0.1D), ((double)CubicBezierNormalDemoControl.Width * 0.8D), ((double)CubicBezierNormalDemoControl.Height * 0.9D), ((double)CubicBezierNormalDemoControl.Width * 0.9D), ((double)CubicBezierNormalDemoControl.Height * 0.2D));
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
