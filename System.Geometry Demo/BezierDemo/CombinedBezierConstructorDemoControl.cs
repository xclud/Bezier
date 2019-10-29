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
using System.DoubleNumerics;

namespace System.Geometry_Demo.BezierDemo
{
    public partial class CombinedBezierContructorDemoControl : UserControl
    {
        public CombinedBezierContructorDemoControl()
        {
            InitializeComponent();
            linearBezier.Bezier = new Bezier(150, 40, 105, 150);
            //linearBezier.Bezier = new Bezier(new Vector2(150, 40), new Vector2(105, 150));
            linearBezier.Bezier = new Bezier(150, 40, 105, 150);
            quadraticBezier.Bezier = new Bezier(150, 40, 80, 30, 105, 150);
            //quadraticBezier.Bezier = new Bezier(new Vector2(150, 40), new Vector2(80, 30), new Vector2(105, 150));
            cubicBezier.Bezier = new Bezier(100, 25, 10, 90, 110, 100, 150, 195);
            //cubicBezier.Bezier = new Bezier(new Vector2(100, 25), new Vector2(10, 90), new Vector2(110, 100), new Vector2(150, 195));

            
            
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
