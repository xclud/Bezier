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
    public partial class CombinedBezierReduceDemoControl : UserControl
    {
        public CombinedBezierReduceDemoControl()
        {
            InitializeComponent();


            QuadraticReduceControl.Bezier = new Bezier(((double)QuadraticReduceControl.Width / 170 * 150), ((double)QuadraticReduceControl.Height / 170 * 40), ((double)QuadraticReduceControl.Width / 170 * 80), ((double)QuadraticReduceControl.Height / 170 * 30), ((double)QuadraticReduceControl.Width / 170 * 105), ((double)QuadraticReduceControl.Height / 170 * 150)); ;
            CubicReduceControl.Bezier = new Bezier(((double)CubicReduceControl.Width / 200 * 100), ((double)CubicReduceControl.Height / 200 * 25), ((double)CubicReduceControl.Width / 200 * 10), ((double)CubicReduceControl.Height / 200 * 90), ((double)CubicReduceControl.Width / 200 * 110), ((double)CubicReduceControl.Height / 200 * 100), ((double)CubicReduceControl.Width / 200 * 150), ((double)CubicReduceControl.Height / 200 * 195));
        }

   
    }
}
