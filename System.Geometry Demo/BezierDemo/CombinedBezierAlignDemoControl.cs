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
    public partial class CombinedBezierAlignDemoControl : UserControl
    {
        public CombinedBezierAlignDemoControl()
        {
            InitializeComponent();

            QuadraticAlignControl.Bezier = new Bezier(((double)QuadraticAlignControl.Width / 170 * 20), ((double)QuadraticAlignControl.Height / 170 * 150), ((double)QuadraticAlignControl.Width / 170 * 40), ((double)QuadraticAlignControl.Height / 170 * 20), ((double)QuadraticAlignControl.Width / 170 * 150), ((double)QuadraticAlignControl.Height / 170 * 130)); ;
            CubicAlignControl.Bezier = new Bezier(((double)CubicAlignControl.Width / 200 * 20), ((double)CubicAlignControl.Height / 200 * 180), ((double)CubicAlignControl.Width / 200 * 30), ((double)CubicAlignControl.Height / 200 * 70), ((double)CubicAlignControl.Width / 200 * 130), ((double)CubicAlignControl.Height / 200 * 15), ((double)CubicAlignControl.Width / 200 * 180), ((double)CubicAlignControl.Height / 200 * 185));
        }

   
    }
}
