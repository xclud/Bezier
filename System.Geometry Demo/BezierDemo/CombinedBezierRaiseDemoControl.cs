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
    public partial class CombinedBezierRaiseDemoControl : UserControl
    {
        public CombinedBezierRaiseDemoControl()
        {
            InitializeComponent();
            QuadraticCurveDemoControl.Bezier = new Bezier(((double)QuadraticCurveDemoControl.Width * 0.3D), ((double)QuadraticCurveDemoControl.Height * 0.1D), ((double)QuadraticCurveDemoControl.Width * 0.6D), ((double)QuadraticCurveDemoControl.Height * 0.9D), ((double)QuadraticCurveDemoControl.Width * 0.9D), ((double)QuadraticCurveDemoControl.Height * 0.2D)); ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
