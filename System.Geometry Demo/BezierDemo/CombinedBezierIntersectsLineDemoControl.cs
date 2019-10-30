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
    public partial class CombinedBezierIntersectsLineDemoControl : UserControl
    {
        public CombinedBezierIntersectsLineDemoControl()
        {
            InitializeComponent();
            QuadraticLineIntersectsControl.Bezier = new Bezier(((double)QuadraticLineIntersectsControl.Width * 0.3D), ((double)QuadraticLineIntersectsControl.Height * 0.7D), ((double)QuadraticLineIntersectsControl.Width * 0.5D), ((double)QuadraticLineIntersectsControl.Height * 0.1D), ((double)QuadraticLineIntersectsControl.Width * 0.9D), ((double)QuadraticLineIntersectsControl.Height * 0.6D)); ;
       CubicLineIntersectsControl.Bezier = new Bezier(((double)CubicLineIntersectsControl.Width * 0.1D), ((double)CubicLineIntersectsControl.Height * 0.8D), ((double)CubicLineIntersectsControl.Width * 0.2D), ((double)CubicLineIntersectsControl.Height * 0.1D), ((double)CubicLineIntersectsControl.Width * 0.8D), ((double)CubicLineIntersectsControl.Height * 0.9D), ((double)CubicLineIntersectsControl.Width * 0.9D), ((double)CubicLineIntersectsControl.Height * 0.2D));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
