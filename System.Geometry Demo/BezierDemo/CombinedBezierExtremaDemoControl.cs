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
    public partial class CombinedBezierExtremaDemoControl : UserControl
    {
        public CombinedBezierExtremaDemoControl()
        {
            InitializeComponent();
            QuadraticExtremaControl.Bezier = new Bezier(150, 40, 80, 30, 105, 150);
            CubicExtremaControl.Bezier = new Bezier(100, 25, 10, 90, 110, 100, 150, 195);
            
            //QuadraticExtremaControl.Bezier = new Bezier(((double)QuadraticExtremaControl.Width/170* 150), ((double)QuadraticExtremaControl.Height / 170 * 40), ((double)QuadraticExtremaControl.Width / 170 * 80), ((double)QuadraticExtremaControl.Height / 170 * 30), ((double)QuadraticExtremaControl.Width / 170 * 105), ((double)QuadraticExtremaControl.Height / 170 * 150)); ;
            //CubicExtremaControl.Bezier = new Bezier(((double)CubicExtremaControl.Width/200*100), ((double)CubicExtremaControl.Height / 200 *25), ((double)CubicExtremaControl.Width / 200 *10), ((double)CubicExtremaControl.Height / 200 *90), ((double)CubicExtremaControl.Width / 200 *110), ((double)CubicExtremaControl.Height / 200 *100), ((double)CubicExtremaControl.Width / 200 *150), ((double)CubicExtremaControl.Height / 200 *195));
        }

   
    }
}
