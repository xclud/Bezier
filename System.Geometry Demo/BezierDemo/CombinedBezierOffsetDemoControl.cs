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
    public partial class CombinedBezierOffsetDemoControl : UserControl
    {
        public CombinedBezierOffsetDemoControl()
        {
            InitializeComponent();
            QuadraticOffsetControl.Bezier = new Bezier(((double)QuadraticOffsetControl.Width * 0.3D), ((double)QuadraticOffsetControl.Height * 0.1D), ((double)QuadraticOffsetControl.Width * 0.6D), ((double)QuadraticOffsetControl.Height * 0.9D), ((double)QuadraticOffsetControl.Width * 0.9D), ((double)QuadraticOffsetControl.Height * 0.2D)); ;
            CubicOffsetControl.Bezier = new Bezier(((double)CubicOffsetControl.Width * 0.1D), ((double)CubicOffsetControl.Height * 0.8D), ((double)CubicOffsetControl.Width * 0.2D), ((double)CubicOffsetControl.Height * 0.1D), ((double)CubicOffsetControl.Width * 0.8D), ((double)CubicOffsetControl.Height * 0.9D), ((double)CubicOffsetControl.Width * 0.9D), ((double)CubicOffsetControl.Height * 0.2D));
        }

     
    }
}
