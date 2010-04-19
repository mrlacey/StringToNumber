//-----------------------------------------------------------------------
// <copyright file="NumberParser.ToMethods.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumber
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// All methods for direct conversion to a numeric type
    /// </summary>
    public partial class NumberParser
    {
        public byte ToByte(string textToParse)
        {
            return Convert.ToByte(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public sbyte ToSByte(string textToParse)
        {
            return Convert.ToSByte(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public UInt16 ToUInt16(string textToParse)
        {
            return Convert.ToUInt16(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public uint ToUInt(string textToParse)
        {
            return Convert.ToUInt32(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public UInt32 ToUInt32(string textToParse)
        {
            return Convert.ToUInt32(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public UInt64 ToUInt64(string textToParse)
        {
            return Convert.ToUInt64(this.WordsToNumber(textToParse), this.converterCulture);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "ushort", Justification = "Deliberately also including type names to provide more usage options")]
        public ushort ToUShort(string textToParse)
        {
            return Convert.ToUInt16(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public Int16 ToInt16(string textToParse)
        {
            return Convert.ToInt16(this.WordsToNumber(textToParse), this.converterCulture);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "short", Justification = "Deliberately also including type names to provide more usage options")]
        public short ToShort(string textToParse)
        {
            return Convert.ToInt16(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public Int32 ToInt32(string textToParse)
        {
            return Convert.ToInt32(this.WordsToNumber(textToParse), this.converterCulture);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "int", Justification = "Deliberately also including type names to provide more usage options")]
        public int ToInt(string textToParse)
        {
            return Convert.ToInt32(this.WordsToNumber(textToParse), this.converterCulture);
        }

        public Int64 ToInt64(string textToParse)
        {
            return Convert.ToInt64(this.WordsToNumber(textToParse), this.converterCulture);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "long", Justification = "Deliberately also including type names to provide more usage options")]
        public long ToLong(string textToParse)
        {
            return Convert.ToInt64(this.WordsToNumber(textToParse), this.converterCulture);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "ulong", Justification = "Deliberately also including type names to provide more usage options")]
        public ulong ToULong(string textToParse)
        {
            return Convert.ToUInt64(this.WordsToNumber(textToParse), this.converterCulture);
        }
    }
}
