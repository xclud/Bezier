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
    public partial class CombinedBezierLengthDemoControl : UserControl
    {
        public CombinedBezierLengthDemoControl()
        {
            InitializeComponent();
            QuadraticLengthControl.Bezier = new Bezier(((double)QuadraticLengthControl.Width * 0.3D), ((double)QuadraticLengthControl.Height * 0.1D), ((double)QuadraticLengthControl.Width * 0.6D), ((double)QuadraticLengthControl.Height * 0.9D), ((double)QuadraticLengthControl.Width * 0.9D), ((double)QuadraticLengthControl.Height * 0.2D)); ;
            CubicLengthControl.Bezier = new Bezier(((double)CubicLengthControl.Width * 0.1D), ((double)CubicLengthControl.Height * 0.8D), ((double)CubicLengthControl.Width * 0.2D), ((double)CubicLengthControl.Height * 0.1D), ((double)CubicLengthControl.Width * 0.8D), ((double)CubicLengthControl.Height * 0.9D), ((double)CubicLengthControl.Width * 0.9D), ((double)CubicLengthControl.Height * 0.2D));
        }

     
    }
}
