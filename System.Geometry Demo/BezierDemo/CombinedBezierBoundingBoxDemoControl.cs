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
    public partial class CombinedBezierBoundingBoxDemoControl : UserControl
    {
        public CombinedBezierBoundingBoxDemoControl()
        {
            InitializeComponent();
            QuadraticBoundingBoxControl.Bezier = new Bezier(((double)QuadraticBoundingBoxControl.Width * 0.3D), ((double)QuadraticBoundingBoxControl.Height * 0.1D), ((double)QuadraticBoundingBoxControl.Width * 0.6D), ((double)QuadraticBoundingBoxControl.Height * 0.9D), ((double)QuadraticBoundingBoxControl.Width * 0.9D), ((double)QuadraticBoundingBoxControl.Height * 0.2D)); ;
            CubicBoundingBoxControl.Bezier = new Bezier(((double)CubicBoundingBoxControl.Width * 0.1D), ((double)CubicBoundingBoxControl.Height * 0.8D), ((double)CubicBoundingBoxControl.Width * 0.2D), ((double)CubicBoundingBoxControl.Height * 0.1D), ((double)CubicBoundingBoxControl.Width * 0.8D), ((double)CubicBoundingBoxControl.Height * 0.9D), ((double)CubicBoundingBoxControl.Width * 0.9D), ((double)CubicBoundingBoxControl.Height * 0.2D));
       }

     
    }
}
