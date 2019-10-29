﻿using System;
using System.Collections.Generic;
using System.DoubleNumerics;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Geometry_Demo.BezierDemo
{
    public class BezierPartDemoControl : BezierDemoControl
    {
        public BezierPartDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

          
            Bezier p =  Bezier.Part(0.25,0.6);
            DrawBezier(e.Graphics,p.Points, Color.Red, BezierWidth);
            DrawHandles(e.Graphics, p.Points, Color.Green, 10, 1, Color.Green, 1);

        }


    }
}
