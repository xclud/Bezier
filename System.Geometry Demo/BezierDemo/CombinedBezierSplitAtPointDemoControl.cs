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
    public partial class CombinedBezierSplitAtPointDemoControl : UserControl
    {
        public CombinedBezierSplitAtPointDemoControl()
        {
            InitializeComponent();
            QuadratitDemoControl.Bezier = new Bezier(((double)QuadratitDemoControl.Width * 0.3D), ((double)QuadratitDemoControl.Height * 0.7D), ((double)QuadratitDemoControl.Width * 0.5D), ((double)QuadratitDemoControl.Height * 0.1D), ((double)QuadratitDemoControl.Width * 0.9D), ((double)QuadratitDemoControl.Height * 0.6D)); ;
            CubicDemoControl.Bezier = new Bezier(((double)CubicDemoControl.Width * 0.1D), ((double)CubicDemoControl.Height * 0.8D), ((double)CubicDemoControl.Width * 0.2D), ((double)CubicDemoControl.Height * 0.1D), ((double)CubicDemoControl.Width * 0.8D), ((double)CubicDemoControl.Height * 0.9D), ((double)CubicDemoControl.Width * 0.9D), ((double)CubicDemoControl.Height * 0.2D));
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
