﻿//-----------------------------------------------------------------------
// <copyright file="NumberParser.TryToMethods.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Globalization;

namespace StringToNumber
{
    /// <summary>
    /// All methods for trying to convert to a numeric type
    /// </summary>
    public partial class NumberParser
    {
        public bool TryToSByte(string textToParse, out sbyte result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToSByte(string textToParse, CultureInfo culture, out sbyte result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToShort(string textToParse, out short result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToShort(string textToParse, CultureInfo culture, out short result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToInt(string textToParse, out int result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToInt(string textToParse, CultureInfo culture, out int result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToLong(string textToParse, out long result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, Scale.Short, out result);
        }

        public bool TryToLong(string textToParse, CultureInfo culture, out long result)
        {
            return this.TryParse(textToParse, culture, Scale.Short, out result);
        }

        public bool TryToLong(string textToParse, Scale scale, out long result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, scale, out result);
        }

        public bool TryToLong(string textToParse, CultureInfo culture, Scale scale, out long result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToByte(string textToParse, out byte result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToByte(string textToParse, CultureInfo culture, out byte result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToUShort(string textToParse, out ushort result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToUShort(string textToParse, CultureInfo culture, out ushort result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToUInt(string textToParse, out uint result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToUInt(string textToParse, CultureInfo culture, out uint result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToInt16(string textToParse, out Int16 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToInt16(string textToParse, CultureInfo culture, out Int16 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToInt32(string textToParse, out Int32 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToInt23(string textToParse, CultureInfo culture, out Int32 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToInt64(string textToParse, out Int64 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToInt64(string textToParse, CultureInfo culture, out Int64 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToUInt16(string textToParse, out UInt16 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToUInt16(string textToParse, CultureInfo culture, out UInt16 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToUInt32(string textToParse, out UInt32 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToUInt32(string textToParse, CultureInfo culture, out UInt32 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToUInt64(string textToParse, out UInt64 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryToUInt64(string textToParse, Scale scale, out UInt64 result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, scale, out result);
        }

        public bool TryToUInt64(string textToParse, CultureInfo culture, Scale scale, out UInt64 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToUInt64(string textToParse, CultureInfo culture, out UInt64 result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        public bool TryToULong(string textToParse, out ulong result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, Scale.Short, out result);
        }

        public bool TryToULong(string textToParse, CultureInfo culture, out ulong result)
        {
            return this.TryParse(textToParse, culture, Scale.Short, out result);
        }

        public bool TryToULong(string textToParse, Scale scale, out ulong result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, scale, out result);
        }

        public bool TryToULong(string textToParse, CultureInfo culture, Scale scale, out ulong result)
        {
            return this.TryParse(textToParse, culture, out result);
        }

        ////public bool TryToFloat(string textToParse, out float result)
        ////{
        ////    return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        ////}

        ////public bool TryToFloat(string textToParse, CultureInfo culture, out float result)
        ////{
        ////    return this.TryParse(textToParse, culture, out result);
        ////}

        ////public bool TryToDouble(string textToParse, out double result)
        ////{
        ////    return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        ////}

        ////public bool TryToDouble(string textToParse, CultureInfo culture, out double result)
        ////{
        ////    return this.TryParse(textToParse, culture, out result);
        ////}

        ////public bool TryToDecimal(string textToParse, out decimal result)
        ////{
        ////    return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        ////}

        ////public bool TryToDecimal(string textToParse, CultureInfo culture, out decimal result)
        ////{
        ////    return this.TryParse(textToParse, culture, out result);
        ////}
    }
}
