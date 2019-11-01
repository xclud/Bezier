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
    public partial class CombinedBezierIsSimpleDemoControl : UserControl
    {
        public CombinedBezierIsSimpleDemoControl()
        {
            InitializeComponent();
            QuadraticDemoControl.Bezier = new Bezier(((double)QuadraticDemoControl.Width * 0.3D), ((double)QuadraticDemoControl.Height * 0.1D), ((double)QuadraticDemoControl.Width * 0.6D), ((double)QuadraticDemoControl.Height * 0.35D), ((double)QuadraticDemoControl.Width * 0.9D), ((double)QuadraticDemoControl.Height * 0.2D)); ;
            CubicDemoControl.Bezier = new Bezier(((double)CubicDemoControl.Width * 0.1D), ((double)CubicDemoControl.Height * 0.8D), ((double)CubicDemoControl.Width * 0.2D), ((double)CubicDemoControl.Height * 0.1D), ((double)CubicDemoControl.Width * 0.8D), ((double)CubicDemoControl.Height * 0.9D), ((double)CubicDemoControl.Width * 0.9D), ((double)CubicDemoControl.Height * 0.2D));
        }

     
    }
}
