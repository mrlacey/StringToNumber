//-----------------------------------------------------------------------
// <copyright file="NumberParser.TryParseMethods.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Globalization;

namespace StringToNumber
{
    public partial class NumberParser
    {
        public bool TryParse(string textToParse, out sbyte result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < sbyte.MinValue || parsed > sbyte.MaxValue)
            {
                result = default(sbyte);
                return false;
            }
            else
            {
                result = sbyte.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out short result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < short.MinValue || parsed > short.MaxValue)
            {
                result = default(short);
                return false;
            }
            else
            {
                result = short.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out int result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < int.MinValue || parsed > int.MaxValue)
            {
                result = default(int);
                return false;
            }
            else
            {
                result = int.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out long result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < long.MinValue || parsed > long.MaxValue)
            {
                result = default(long);
                return false;
            }
            else
            {
                result = long.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out byte result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < byte.MinValue || parsed > byte.MaxValue)
            {
                result = default(byte);
                return false;
            }
            else
            {
                result = byte.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out ushort result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < ushort.MinValue || parsed > ushort.MaxValue)
            {
                result = default(ushort);
                return false;
            }
            else
            {
                result = ushort.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out uint result)
        {
            bool hadError;
            var parsed = this.WordsToNumber(textToParse, false, out hadError);

            if (hadError || parsed < uint.MinValue || parsed > uint.MaxValue)
            {
                result = default(uint);
                return false;
            }
            else
            {
                result = uint.Parse(parsed.ToString());
                return true;
            }
        }

        public bool TryParse(string textToParse, out ulong result)
        {
            // TODO: implement this - issue converting long to ulong :(
            result = 0; // default to zero (if returning false) 
            return false;
        }

        ////public bool TryParse(string textToParse, out float result)
        ////{
        ////    return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        ////}

        ////public bool TryParse(string textToParse, CultureInfo culture, out float result)
        ////{
        ////    // TODO: implement this (when add support for float)
        ////    result = 0; // default to zero (if returning false) 
        ////    return false;
        ////}

        ////public bool TryParse(string textToParse, out double result)
        ////{
        ////    return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        ////}

        ////public bool TryParse(string textToParse, CultureInfo culture, out double result)
        ////{
        ////    // TODO: implement this (when add support for double)
        ////    result = 0; // default to zero (if returning false) 
        ////    return false;
        ////}

        ////public bool TryParse(string textToParse, out decimal result)
        ////{
        ////    return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        ////}

        ////public bool TryParse(string textToParse, CultureInfo culture, out decimal result)
        ////{
        ////    // TODO: implement this (when add support for decimal)
        ////    result = 0; // default to zero (if returning false) 
        ////    return false;
        ////}
    }
}
