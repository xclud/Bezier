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
    public partial class CombinedBezierBoundingBoxOverlapsDemoControl : UserControl
    {
        public CombinedBezierBoundingBoxOverlapsDemoControl()
        {
            InitializeComponent();
            QuadraticCurveDemoControl.Bezier = new Bezier(((double)QuadraticCurveDemoControl.Width * 0.3D), ((double)QuadraticCurveDemoControl.Height * 0.1D), ((double)QuadraticCurveDemoControl.Width * 0.6D), ((double)QuadraticCurveDemoControl.Height * 0.9D), ((double)QuadraticCurveDemoControl.Width * 0.9D), ((double)QuadraticCurveDemoControl.Height * 0.2D)); ;
            CubicCurveDemoControl.Bezier = new Bezier(((double)CubicCurveDemoControl.Width * 0.1D), ((double)CubicCurveDemoControl.Height * 0.8D), ((double)CubicCurveDemoControl.Width * 0.2D), ((double)CubicCurveDemoControl.Height * 0.1D), ((double)CubicCurveDemoControl.Width * 0.8D), ((double)CubicCurveDemoControl.Height * 0.9D), ((double)CubicCurveDemoControl.Width * 0.9D), ((double)CubicCurveDemoControl.Height * 0.2D));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
