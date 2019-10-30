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
    public partial class CombinedBezierHullDemoControl : UserControl
    {
        public CombinedBezierHullDemoControl()
        {
            InitializeComponent();

            QuadraticHullControl.Bezier = new Bezier(((double)QuadraticHullControl.Width / 170 * 20), ((double)QuadraticHullControl.Height / 170 * 150), ((double)QuadraticHullControl.Width / 170 * 40), ((double)QuadraticHullControl.Height / 170 * 20), ((double)QuadraticHullControl.Width / 170 * 150), ((double)QuadraticHullControl.Height / 170 * 130)); ;
            CubicHullControl.Bezier = new Bezier(((double)CubicHullControl.Width / 200 * 20), ((double)CubicHullControl.Height / 200 * 180), ((double)CubicHullControl.Width / 200 * 30), ((double)CubicHullControl.Height / 200 * 70), ((double)CubicHullControl.Width / 200 * 130), ((double)CubicHullControl.Height / 200 * 15), ((double)CubicHullControl.Width / 200 * 180), ((double)CubicHullControl.Height / 200 * 185));
        }

   
    }
}
