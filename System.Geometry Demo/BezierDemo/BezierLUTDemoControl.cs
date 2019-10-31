using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DoubleNumerics;
using System.Drawing;
using System.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Geometry_Demo.BezierDemo
{
    public class BezierLUTDemoControl : BezierDemoControl
    {
        public BezierLUTDemoControl() : base()
        {
            Bezier = new Bezier(((double)Width * 0.1D), ((double)Height * 0.9D), ((double)Width * 0.2D), ((double)Height * 0.2D), ((double)Width * 0.7D), ((double)Height * 0.8D), ((double)Width * 0.8D), ((double)Height * 0.1D));
        }

        #region LookupTableSteps property of type int with events
        #region LookupTableSteps property core parts
        private int _LookupTableSteps = 10;

        /// <summary>
        ///  LookupTableSteps property of type int
        /// </summary>
        [Category("Geometry")]
        [DisplayName("LookUpTable steps")]
        [Description("Number of steps/point for the LookupTable")]
        public int LookupTableSteps
        {
            get { return _LookupTableSteps; }
            set
            {
                if (_LookupTableSteps != value)
                {
                    OnLookupTableStepsChanging();
                    _LookupTableSteps = value;
                    OnLookupTableStepsChanged();
                }
            }
        }

        /// <summary>
        /// Fires when the LookupTableSteps property is about to change its value
        /// </summary>
        public event EventHandler<EventArgs> LookupTableStepsChanging;

        /// <summary>
        /// Fires when the LookupTableSteps property has changed its value
        /// </summary>
        public event EventHandler<EventArgs> LookupTableStepsChanged;
        #endregion

        /// <summary>
        /// Is called when the LookupTableSteps property is about to change its value and fires the LookupTableStepsChanging event
        /// </summary>
        protected void OnLookupTableStepsChanging()
        {
            LookupTableStepsChanging?.Invoke(this, new EventArgs());
            //Insert more logic to execute before the LookupTableSteps property changes here
        }

        /// <summary>
        /// Is called when the LookupTableSteps property has changed its value and fires the LookupTableStepsChanged event
        /// </summary>
        protected void OnLookupTableStepsChanged()
        {
            //Insert more logic to execute after the LookupTableSteps property has changed here
            LookupTableStepsChanged?.Invoke(this, new EventArgs());

        }

        #endregion

        protected override void OnBezierChanged()
        {
            base.OnBezierChanged();
            LookUpTable = new LookUpTableEquidistant(Bezier, (LookupTableSteps>0? LookupTableSteps : 1));
        }

        #region LookUpTable property of type LookUpTable with events
        #region LookUpTable property core parts
        private LookUpTableEquidistant _LookUpTable = null;

        /// <summary>
        ///  LookUpTable property of type LookUpTable
        /// </summary>
        public LookUpTableEquidistant LookUpTable
        {
            get { return _LookUpTable; }
            set
            {
                if (_LookUpTable != value)
                {
                    OnLookUpTableChanging();
                    _LookUpTable = value;
                    OnLookUpTableChanged();
                }
            }
        }

        /// <summary>
        /// Fires when the LookUpTable property is about to change its value
        /// </summary>
        public event EventHandler<EventArgs> LookUpTableChanging;

        /// <summary>
        /// Fires when the LookUpTable property has changed its value
        /// </summary>
        public event EventHandler<EventArgs> LookUpTableChanged;
        #endregion

        /// <summary>
        /// Is called when the LookUpTable property is about to change its value and fires the LookUpTableChanging event
        /// </summary>
        protected void OnLookUpTableChanging()
        {
            if (LookUpTableChanging != null) LookUpTableChanging(this, new EventArgs());

            //Insert more logic to execute before the LookUpTable property changes here
        }

        /// <summary>
        /// Is called when the LookUpTable property has changed its value and fires the LookUpTableChanged event
        /// </summary>
        protected void OnLookUpTableChanged()
        {
            //Insert more logic to execute after the LookUpTable property has changed here

            if (LookUpTableChanged != null) LookUpTableChanged(this, new EventArgs());
        }

        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (LookUpTable == null) return;

            //LookUpTable = new LookUpTable(Bezier,10);
            foreach (Vector2 point in LookUpTable)
            {
                DrawPoint(e.Graphics, point, Color.Blue, 8);
               
            }
        }


    }
}
