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
    public partial class CombinedBezierScaleDemoControl : UserControl
    {
        public CombinedBezierScaleDemoControl()
        {
            InitializeComponent();

            QuadraticControl.Bezier = new Bezier(((double)QuadraticControl.Width / 170 * 20), ((double)QuadraticControl.Height / 170 * 150), ((double)QuadraticControl.Width / 170 * 40), ((double)QuadraticControl.Height / 170 * 20), ((double)QuadraticControl.Width / 170 * 150), ((double)QuadraticControl.Height / 170 * 130)); ;
            CubicControl.Bezier = new Bezier(((double)CubicControl.Width / 200 * 20), ((double)CubicControl.Height / 200 * 180), ((double)CubicControl.Width / 200 * 30), ((double)CubicControl.Height / 200 * 70), ((double)CubicControl.Width / 200 * 130), ((double)CubicControl.Height / 200 * 15), ((double)CubicControl.Width / 200 * 180), ((double)CubicControl.Height / 200 * 185));
        }

   
    }
}
