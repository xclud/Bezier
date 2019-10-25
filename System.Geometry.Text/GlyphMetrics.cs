using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace System.Geometry.Text
{
    /// <summary>
    /// Contains metrics for a single glyph.
    /// </summary>
    public struct GlyphMetrics
    {
        /// <summary>
        /// The glyph advance; this is the distance to advance the pen after positioning the glyph.
        /// </summary>
        public readonly double Advance;

        /// <summary>
        /// The linear advance; this is the original advance distance unaffected by hinting.
        /// Use this if you want a guaranteed smooth transition of advances across various pixel sizes.
        /// </summary>
        public readonly double LinearAdvance;

        /// <summary>
        /// Initializes a new instance of the <see cref="GlyphMetrics"/> struct.
        /// </summary>
        /// <param name="advance">The advance distance.</param>
        /// <param name="linearAdvance">The linear unhinted advance distance.</param>
        internal GlyphMetrics(double advance, double linearAdvance)
        {
            Advance = advance;
            LinearAdvance = linearAdvance;
        }
    }
}
