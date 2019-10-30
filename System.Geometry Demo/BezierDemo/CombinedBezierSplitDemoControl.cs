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
    public partial class CombinedBezierSplitDemoControl : UserControl
    {
        public CombinedBezierSplitDemoControl()
        {
            InitializeComponent();
            QuadraticBezierSplitDemoControl.Bezier = new Bezier(((double)QuadraticBezierSplitDemoControl.Width * 0.3D), ((double)QuadraticBezierSplitDemoControl.Height * 0.7D), ((double)QuadraticBezierSplitDemoControl.Width * 0.5D), ((double)QuadraticBezierSplitDemoControl.Height * 0.1D), ((double)QuadraticBezierSplitDemoControl.Width * 0.9D), ((double)QuadraticBezierSplitDemoControl.Height * 0.6D)); ;
            CubicBezierSplitDemoControl.Bezier = new Bezier(((double)CubicBezierSplitDemoControl.Width * 0.1D), ((double)CubicBezierSplitDemoControl.Height * 0.8D), ((double)CubicBezierSplitDemoControl.Width * 0.2D), ((double)CubicBezierSplitDemoControl.Height * 0.1D), ((double)CubicBezierSplitDemoControl.Width * 0.8D), ((double)CubicBezierSplitDemoControl.Height * 0.9D), ((double)CubicBezierSplitDemoControl.Width * 0.9D), ((double)CubicBezierSplitDemoControl.Height * 0.2D));
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
