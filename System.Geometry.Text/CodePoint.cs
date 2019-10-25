using System;
using System.Collections.Generic;
using System.Text;

namespace System.Geometry.Text
{
    /// <summary>
    /// Represents a single Unicode codepoint.
    /// </summary>
    public struct CodePoint : IComparable<CodePoint>, IEquatable<CodePoint>
    {
        readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodePoint"/> struct.
        /// </summary>
        /// <param name="codePoint">The 32-bit value of the codepoint.</param>
        public CodePoint(int codePoint)
        {
            value = codePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodePoint"/> struct.
        /// </summary>
        /// <param name="character">The 16-bit value of the codepoint.</param>
        public CodePoint(char character)
        {
            value = character;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodePoint"/> struct.
        /// </summary>
        /// <param name="highSurrogate">The first member of a surrogate pair representing the codepoint.</param>
        /// <param name="lowSurrogate">The second member of a surrogate pair representing the codepoint.</param>
        public CodePoint(char highSurrogate, char lowSurrogate)
        {
            value = char.ConvertToUtf32(highSurrogate, lowSurrogate);
        }

        /// <summary>
        /// Compares this instance to the specified value.
        /// </summary>
        /// <param name="other">The value to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
        public int CompareTo(CodePoint other) => value.CompareTo(other.value);

        /// <summary>
        /// Returns a value indicating whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns><c>true</c> if this instance equals <paramref name="other"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(CodePoint other) => value.Equals(other.value);

        /// <summary>
        /// Returns a value indicating whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns><c>true</c> if this instance equals <paramref name="obj"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            var codepoint = obj as CodePoint?;
            if (codepoint == null)
                return false;

            return Equals(codepoint);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The instance's hashcode.</returns>
        public override int GetHashCode() => value.GetHashCode();

        /// <summary>
        /// Converts the value to its equivalent string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{value} ({(char)value})";

        /// <summary>
        /// Implements the equality operator.
        /// </summary>
        /// <param name="left">The left hand side of the operator.</param>
        /// <param name="right">The right hand side of the operator.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CodePoint left, CodePoint right) => left.Equals(right);

        /// <summary>
        /// Implements the inequality operator.
        /// </summary>
        /// <param name="left">The left hand side of the operator.</param>
        /// <param name="right">The right hand side of the operator.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CodePoint left, CodePoint right) => !left.Equals(right);

        /// <summary>
        /// Implements the less-than operator.
        /// </summary>
        /// <param name="left">The left hand side of the operator.</param>
        /// <param name="right">The right hand side of the operator.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(CodePoint left, CodePoint right) => left.value < right.value;

        /// <summary>
        /// Implements the greater-than operator.
        /// </summary>
        /// <param name="left">The left hand side of the operator.</param>
        /// <param name="right">The right hand side of the operator.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(CodePoint left, CodePoint right) => left.value > right.value;

        /// <summary>
        /// Implements the less-than-or-equal-to operator.
        /// </summary>
        /// <param name="left">The left hand side of the operator.</param>
        /// <param name="right">The right hand side of the operator.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(CodePoint left, CodePoint right) => left.value <= right.value;

        /// <summary>
        /// Implements the greater-than-or-equal-to operator.
        /// </summary>
        /// <param name="left">The left hand side of the operator.</param>
        /// <param name="right">The right hand side of the operator.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(CodePoint left, CodePoint right) => left.value >= right.value;

        /// <summary>
        /// Implements an explicit conversion from integer to <see cref="CodePoint"/>.
        /// </summary>
        /// <param name="codePoint">The codepoint value.</param>
        public static explicit operator CodePoint(int codePoint) => new CodePoint(codePoint);

        /// <summary>
        /// Implements an implicit conversion from character to <see cref="CodePoint"/>.
        /// </summary>
        /// <param name="character">The character value.</param>
        public static implicit operator CodePoint(char character) => new CodePoint(character);

        /// <summary>
        /// Implements an explicit conversion from <see cref="CodePoint"/> to character.
        /// </summary>
        /// <param name="codePoint">The codepoint value.</param>
        public static explicit operator char(CodePoint codePoint) => (char)codePoint.value;
    }
}
