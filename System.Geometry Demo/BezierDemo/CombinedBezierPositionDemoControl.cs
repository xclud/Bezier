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
    public partial class CombinedBezierPositionDemoControl : UserControl
    {
        public CombinedBezierPositionDemoControl()
        {
            InitializeComponent();
            QuadraticPositionControl.Bezier = new Bezier(((double)QuadraticPositionControl.Width * 0.3D), ((double)QuadraticPositionControl.Height * 0.1D), ((double)QuadraticPositionControl.Width * 0.6D), ((double)QuadraticPositionControl.Height * 0.9D), ((double)QuadraticPositionControl.Width * 0.9D), ((double)QuadraticPositionControl.Height * 0.2D)); ;
            CubicPoisitionControl.Bezier = new Bezier(((double)CubicPoisitionControl.Width * 0.1D), ((double)CubicPoisitionControl.Height * 0.8D), ((double)CubicPoisitionControl.Width * 0.2D), ((double)CubicPoisitionControl.Height * 0.1D), ((double)CubicPoisitionControl.Width * 0.8D), ((double)CubicPoisitionControl.Height * 0.9D), ((double)CubicPoisitionControl.Width * 0.9D), ((double)CubicPoisitionControl.Height * 0.2D));
       }

     
    }
}
