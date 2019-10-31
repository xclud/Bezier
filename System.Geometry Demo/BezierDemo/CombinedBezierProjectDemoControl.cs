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
    public partial class CombinedBezierProjectDemoControl : UserControl
    {
        public CombinedBezierProjectDemoControl()
        {
            InitializeComponent();
            QuadraticLUTControl.Bezier = new Bezier(((double)QuadraticLUTControl.Width * 0.3D), ((double)QuadraticLUTControl.Height * 0.1D), ((double)QuadraticLUTControl.Width * 0.6D), ((double)QuadraticLUTControl.Height * 0.9D), ((double)QuadraticLUTControl.Width * 0.9D), ((double)QuadraticLUTControl.Height * 0.2D)); ;
            CubicLUTControl.Bezier = new Bezier(((double)CubicLUTControl.Width * 0.1D), ((double)CubicLUTControl.Height * 0.8D), ((double)CubicLUTControl.Width * 0.2D), ((double)CubicLUTControl.Height * 0.1D), ((double)CubicLUTControl.Width * 0.8D), ((double)CubicLUTControl.Height * 0.9D), ((double)CubicLUTControl.Width * 0.9D), ((double)CubicLUTControl.Height * 0.2D));
        }

     
    }
}
