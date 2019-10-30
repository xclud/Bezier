using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DoubleNumerics;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Geometry_Demo.BezierDemo
{
    public partial class BezierDemoForm : Form
    {
        public BezierDemoForm()
        {
            InitializeComponent();
            string rtf = Properties.Resources.Bezier;
            InfoRichTextBox.Rtf = rtf;
        }

        private void combinedBezierIntersectsCurveDemoControl1_Load(object sender, EventArgs e)
        {

        }

        private void InfoRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
