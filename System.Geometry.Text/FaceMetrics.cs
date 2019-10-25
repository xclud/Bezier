using System;
using System.Collections.Generic;
using System.Text;

namespace System.Geometry.Text
{
    /// <summary>
    /// Contains various metrics that apply to a font face as a whole, scaled for a particular size.
    /// </summary>
    public struct FaceMetrics
    {
        /// <summary>
        /// The distance from the baseline up to the top of the em box.
        /// </summary>
        public readonly double CellAscent;

        /// <summary>
        /// The distance from the baseline down to the bottom of the em box.
        /// </summary>
        public readonly double CellDescent;

        /// <summary>
        /// The baseline-to-baseline distance.
        /// </summary>
        public readonly double LineHeight;

        /// <summary>
        /// The average height of "lowercase" characters.
        /// </summary>
        public readonly double XHeight;

        /// <summary>
        /// The average height of "uppercase" characters.
        /// </summary>
        public readonly double CapHeight;

        /// <summary>
        /// The thickness of an underline marker.
        /// </summary>
        public readonly double UnderlineSize;

        /// <summary>
        /// The distance from the baseline at which to place the underline marker.
        /// </summary>
        public readonly double UnderlinePosition;

        /// <summary>
        /// The thickness of a strikeout marker.
        /// </summary>
        public readonly double StrikeoutSize;

        /// <summary>
        /// The distance from the baseline at which to place the strikeout marker.
        /// </summary>
        public readonly double StrikeoutPosition;

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceMetrics"/> class.
        /// </summary>
        /// <param name="cellAscent">The cell ascent.</param>
        /// <param name="cellDescent">The cell descent.</param>
        /// <param name="lineHeight">The line height.</param>
        /// <param name="xHeight">The average height of "lowercase" characters.</param>
        /// <param name="capHeight">The average height of "uppercase" characters.</param>
        /// <param name="underlineSize">The underline size.</param>
        /// <param name="underlinePosition">The underline position.</param>
        /// <param name="strikeoutSize">The strikeout size.</param>
        /// <param name="strikeoutPosition">The strikeout position.</param>
        internal FaceMetrics(
            double cellAscent, double cellDescent, double lineHeight, double xHeight,
            double capHeight, double underlineSize, double underlinePosition,
            double strikeoutSize, double strikeoutPosition
        )
        {
            CellAscent = cellAscent;
            CellDescent = cellDescent;
            LineHeight = lineHeight;
            XHeight = xHeight;
            CapHeight = capHeight;
            UnderlineSize = underlineSize;
            UnderlinePosition = underlinePosition;
            StrikeoutSize = strikeoutSize;
            StrikeoutPosition = strikeoutPosition;
        }
    }
}
