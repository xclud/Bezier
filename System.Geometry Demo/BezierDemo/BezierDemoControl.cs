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
    public partial class BezierDemoControl : UserControl
    {
        public BezierDemoControl()
        {
            InitializeComponent();
        }

        #region Bezier property of type Bezier with events
        #region Bezier property core parts
        private Bezier _Bezier = new Bezier(new Vector2(100, 25), new Vector2(10, 90), new Vector2(110, 100), new Vector2(150, 195));

        /// <summary>
        ///  Bezier property of type Bezier
        /// </summary>
        [Category("Geometry")]
        [DisplayName("Bezier Curve")]
        [Description("DescripThe Bezier Curve to Display")]
        public Bezier Bezier
        {
            get { return _Bezier; }
            set
            {
                if (_Bezier != value)
                {
                    OnBezierChanging();
                    _Bezier = value;
                    OnBezierChanged();
                }
            }
        }

        /// <summary>
        /// Fires when the Bezier property is about to change its value
        /// </summary>
        public event EventHandler<EventArgs> BezierChanging;

        /// <summary>
        /// Fires when the Bezier property has changed its value
        /// </summary>
        public event EventHandler<EventArgs> BezierChanged;
        #endregion

        /// <summary>
        /// Is called when the Bezier property is about to change its value and fires the BezierChanging event
        /// </summary>
        protected virtual void OnBezierChanging()
        {
            BezierChanging?.Invoke(this, new EventArgs());
            //Insert more logic to execute before the Bezier property changes here
        }

        /// <summary>
        /// Is called when the Bezier property has changed its value and fires the BezierChanged event
        /// </summary>
        protected virtual void OnBezierChanged()
        {
            //Insert more logic to execute after the Bezier property has changed here
            BezierChanged?.Invoke(this, new EventArgs());
            Invalidate();
        }

        #endregion

        #region BezierColor property of type Color with events
        #region BezierColor property core parts
        private Color _BezierColor = Color.Black;

        /// <summary>
        ///  BezierColor property of type Color
        /// </summary>
        [Category("Geometry")]
        [DisplayName("Bezier Color")]
        [Description("Color of the Bezier CUrve")]
        public Color BezierColor
        {
            get { return _BezierColor; }
            set
            {
                if (_BezierColor != value)
                {
                    OnBezierColorChanging();
                    _BezierColor = value;
                    OnBezierColorChanged();
                }
            }
        }

        /// <summary>
        /// Fires when the BezierColor property is about to change its value
        /// </summary>
        public event EventHandler<EventArgs> BezierColorChanging;

        /// <summary>
        /// Fires when the BezierColor property has changed its value
        /// </summary>
        public event EventHandler<EventArgs> BezierColorChanged;
        #endregion

        /// <summary>
        /// Is called when the BezierColor property is about to change its value and fires the BezierColorChanging event
        /// </summary>
        protected void OnBezierColorChanging()
        {
            BezierColorChanging?.Invoke(this, new EventArgs());
            //Insert more logic to execute before the BezierColor property changes here
        }

        /// <summary>
        /// Is called when the BezierColor property has changed its value and fires the BezierColorChanged event
        /// </summary>
        protected void OnBezierColorChanged()
        {
            //Insert more logic to execute after the BezierColor property has changed here
            BezierColorChanged?.Invoke(this, new EventArgs());

        }

        #endregion


        #region BezierWidth property of type float with events
        #region BezierWidth property core parts
        private float _BezierWidth = 2;

        /// <summary>
        ///  BezierWidth property of type float
        /// </summary>
        [Category("Geometry")]
        [DisplayName("Bezier Pen Diameter")]
        [Description("Diameter of the bezier curve.")]
        public float BezierWidth
        {
            get { return _BezierWidth; }
            set
            {
                if (_BezierWidth != value)
                {
                    OnBezierWidthChanging();
                    _BezierWidth = value;
                    OnBezierWidthChanged();
                }
            }
        }

        /// <summary>
        /// Fires when the BezierWidth property is about to change its value
        /// </summary>
        public event EventHandler<EventArgs> BezierWidthChanging;

        /// <summary>
        /// Fires when the BezierWidth property has changed its value
        /// </summary>
        public event EventHandler<EventArgs> BezierWidthChanged;
        #endregion

        /// <summary>
        /// Is called when the BezierWidth property is about to change its value and fires the BezierWidthChanging event
        /// </summary>
        protected void OnBezierWidthChanging()
        {
            BezierWidthChanging?.Invoke(this, new EventArgs());
            //Insert more logic to execute before the BezierWidth property changes here
        }

        /// <summary>
        /// Is called when the BezierWidth property has changed its value and fires the BezierWidthChanged event
        /// </summary>
        protected void OnBezierWidthChanged()
        {
            //Insert more logic to execute after the BezierWidth property has changed here
            BezierWidthChanged?.Invoke(this, new EventArgs());

        }

        #endregion


        #region HandleSize property of type uint with events
        #region HandleSize property core parts
        private uint _HandleSize = 15;

        /// <summary>
        ///  HandleSize property of type uint
        /// </summary>
        [Category("Geometry")]
        [DisplayName("Handle SIze")]
        [Description("SIze of the handles (if displayed)")]
        public uint HandleSize
        {
            get { return _HandleSize; }
            set
            {
                if (_HandleSize != value)
                {
                    OnHandleSizeChanging();
                    _HandleSize = value;
                    OnHandleSizeChanged();
                }
            }
        }

        /// <summary>
        /// Fires when the HandleSize property is about to change its value
        /// </summary>
        public event EventHandler<EventArgs> HandleSizeChanging;

        /// <summary>
        /// Fires when the HandleSize property has changed its value
        /// </summary>
        public event EventHandler<EventArgs> HandleSizeChanged;
        #endregion

        /// <summary>
        /// Is called when the HandleSize property is about to change its value and fires the HandleSizeChanging event
        /// </summary>
        protected void OnHandleSizeChanging()
        {
            HandleSizeChanging?.Invoke(this, new EventArgs());
            //Insert more logic to execute before the HandleSize property changes here
        }

        /// <summary>
        /// Is called when the HandleSize property has changed its value and fires the HandleSizeChanged event
        /// </summary>
        protected void OnHandleSizeChanged()
        {
            //Insert more logic to execute after the HandleSize property has changed here
            HandleSizeChanged?.Invoke(this, new EventArgs());

        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias;

            drawControlDrawHandles(gfx);
            drawControlBezier(gfx);

        }

        private void drawControlBezier(Graphics gfx)
        {
            if (Bezier != null)
            {
                DrawBezier(gfx, Bezier.Points, BezierColor, BezierWidth);
            }
        }

        private void drawControlDrawHandles(Graphics gfx)
        {
            if (Bezier != null)
            {
                float handleSize = HandleSize;
                float handleRadius = handleSize / 2;


                if (currentPointIndex >= 0 && currentPointIndex < Bezier.Points.Count)
                {
                    Vector2 bezierPoint = Bezier.Points[currentPointIndex];
                    using (Brush handleFillBrush = new SolidBrush(Color.LightBlue))
                    {
                        gfx.FillEllipse(handleFillBrush, (float)bezierPoint.X - handleRadius, (float)bezierPoint.Y - handleRadius, (float)handleRadius * 2, (float)handleRadius * 2);
                    }
                }

                DrawHandles(gfx, Bezier.Points, Color.Black, HandleSize, 1, Color.LightGray, 1);
            }

        }


        internal void DrawHandles(Graphics gfx, IEnumerable<Vector2> points, Color handleColor, double handleSize, double handleLineWidth, Color sceletonColor, double sceletonLineWidth)
        {

            float handleRadius = (float)(handleSize / 2);

            using (Pen handlePen = new Pen(handleColor, (float)handleLineWidth))
            {
                foreach (Vector2 bezierPoint in points)
                {
                    gfx.DrawEllipse(handlePen, (float)bezierPoint.X - handleRadius, (float)bezierPoint.Y - handleRadius, (float)handleRadius * 2, (float)handleRadius * 2);
                }
            }

            using (Pen linePen = new Pen(sceletonColor, (float)sceletonLineWidth))
            {
                switch (Bezier.Points.Count)
                {
                    case 3:
                        gfx.DrawLine(linePen, Vector2ToPointF(points.ElementAt(0)), Vector2ToPointF(points.ElementAt(1)));
                        gfx.DrawLine(linePen, Vector2ToPointF(points.ElementAt(2)), Vector2ToPointF(points.ElementAt(1)));
                        break;
                    case 4:
                        gfx.DrawLine(linePen, Vector2ToPointF(points.ElementAt(0)), Vector2ToPointF(points.ElementAt(1)));
                        gfx.DrawLine(linePen, Vector2ToPointF(points.ElementAt(2)), Vector2ToPointF(points.ElementAt(3)));

                        break;
                    default:
                        break;
                }
            }
        }

        internal void DrawCircle(Graphics gfx, Vector2 point, Color circleColor, double cirleDiameter, double circleLineWidth = 1)
        {
            Pen circlePen = new Pen(circleColor, (float)circleLineWidth);

            gfx.DrawEllipse(circlePen, (float)(point.X - cirleDiameter / 2), (float)(point.Y - cirleDiameter / 2), (float)cirleDiameter, (float)cirleDiameter);
        }
        internal void DrawPoint(Graphics gfx, Vector2 point, Color pointColor, double pointDiameter)
        {
            Brush pointBrush = new SolidBrush(pointColor);
            gfx.FillEllipse(pointBrush, (float)(point.X - pointDiameter / 2), (float)(point.Y - pointDiameter / 2), (float)pointDiameter, (float)pointDiameter);
        }

        internal void DrawLine(Graphics gfx, Vector2 start, Vector2 end, Color lineColor, double lineWidth)
        {
            Pen linePen = new Pen(lineColor, (float)lineWidth);
            gfx.DrawLine(linePen, Vector2ToPointF(start), Vector2ToPointF(end));
        }

        internal void DrawRectangle(Graphics gfx, Vector2 min, Vector2 max, Color lineColor, double lineWidth)
        {
            Pen linePen = new Pen(lineColor, (float)lineWidth);
            gfx.DrawRectangle(linePen, (int)min.X, (int)min.Y, (int)(max.X - min.X), (int)(max.Y - min.Y));
        }

        internal void DrawText(Graphics gfx, string text, Vector2 position, Color fontColor, double fontSize = 10)
        {
            Font font = new Font("Microsoft Sans Serif", (float)fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            Brush fontBrush = new SolidBrush(fontColor);
            gfx.DrawString(text, font, fontBrush, Vector2ToPointF(position));

        }


        internal void DrawBezier(Graphics gfx, IEnumerable<Vector2> points, Color bezierColor, double bezierWidth)
        {
            Pen bezierPen = new Pen(bezierColor, (float)bezierWidth);
            switch (points.Count())
            {
                case 2:
                    gfx.DrawLine(bezierPen, Vector2ToPointF(points.ElementAt(0)), Vector2ToPointF(points.ElementAt(1)));
                    break;
                case 3:
                    if (Vector2.Distance(points.ElementAt(0), points.ElementAt(1)) > 0.5 || Vector2.Distance(points.ElementAt(1), points.ElementAt(2)) > 0.5)
                    {
                        PointF start = Vector2ToPointF(points.ElementAt(0));

                        PointF cp1 = Vector2ToPointF(points.ElementAt(0) + (2.0d / 3.0d) * (points.ElementAt(1) - points.ElementAt(0)));
                        PointF cp2 = Vector2ToPointF(points.ElementAt(2) + (2.0d / 3.0d) * (points.ElementAt(1) - points.ElementAt(2)));
                        PointF end = Vector2ToPointF(points.ElementAt(2));
                        gfx.DrawBezier(bezierPen, start, cp1, cp2, end);
                    }
                    else
                    {
                        DrawLine(gfx, points.ElementAt(1), points.ElementAt(2), bezierColor, bezierWidth);
                    };
                    break;
                case 4:
                    if (Vector2.Distance(points.ElementAt(0), points.ElementAt(1)) > 0.5 || Vector2.Distance(points.ElementAt(2), points.ElementAt(3)) > 0.5)
                    {
                        PointF[] pts = points.Select(bp => Vector2ToPointF(bp)).ToArray();
                        gfx.DrawBezier(bezierPen, pts[0], pts[1], pts[2], pts[3]);
                    }
                    else
                    {
                        DrawLine(gfx, points.ElementAt(0), points.ElementAt(3), bezierColor, bezierWidth);
                    };

                    break;
                default:
                    throw new Exception($"Invalid number of control points. Curve has {Bezier.Points.Count} control points, but only 2, 3 or 4 control points are allowed");

            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (currentPointIndex >= 0 && currentPointIndex < Bezier.Points.Count)
            {
                currentPointMouseIsDown = true;
                currentPointMouseOffset = Bezier.Points[currentPointIndex] - PointToVector2(e.Location);
            }
        }


        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            currentPointMouseIsDown = false;
            currentPointMouseOffset = Vector2.Zero;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            releaseHandle();
        }



        bool currentPointMouseIsDown = false;
        Vector2 currentPointMouseOffset = Vector2.Zero;
        int currentPointIndex = -1;

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (!currentPointMouseIsDown)
            {
                Vector2 mousePos = PointToVector2(e.Location);

                int closestIndex = -1;


                double dist = double.MaxValue;

                for (int i = 0; i < Bezier.Points.Count; i++)
                {
                    Vector2 cp = Bezier.Points[i];
                    double d = Vector2.Distance(mousePos, cp);
                    if (d < HandleSize / 2 && d < dist)
                    {
                        //Pointer is within handle and closest so far
                        dist = d;
                        closestIndex = i;

                    }
                }

                SetCurrentPoint(closestIndex);
            }
            else
            {
                if (currentPointMouseIsDown && currentPointIndex >= 0 && currentPointIndex < Bezier.Points.Count)
                {
                    Vector2[] pts = Bezier.Points.ToArray();

                    Vector2 newPos = PointToVector2(e.Location) + currentPointMouseOffset;

                    if (newPos.X >= 0 && newPos.X < this.Width && newPos.Y >= 0 && newPos.Y < this.Height)
                    {

                        pts[currentPointIndex] = newPos;

                        Bezier newBezier = new Bezier(pts);

                        Bezier = new Bezier(pts);
                    }
                    else
                    {
                        releaseHandle();
                    }
                }
            }
        }


        private void releaseHandle()
        {
            SetCurrentPoint(-1);
            currentPointMouseIsDown = false;
            currentPointMouseOffset = Vector2.Zero;
        }
        private void SetCurrentPoint(int pointIndex)
        {
            if (currentPointIndex != pointIndex)
            {

                currentPointIndex = pointIndex;

                Invalidate();
            }
        }

        internal Vector2 PointToVector2(Point point)
        {
            return new Vector2(point.X, point.Y);
        }
        internal PointF Vector2ToPointF(DoubleNumerics.Vector2 bp)
        {
            return new PointF((float)bp.X, (float)bp.Y);
        }
    }
}
