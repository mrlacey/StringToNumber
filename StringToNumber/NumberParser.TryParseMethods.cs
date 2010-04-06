//-----------------------------------------------------------------------
// <copyright file="NumberParser.TryParseMethods.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Globalization;

namespace StringToNumber
{
    // http://stackoverflow.com/questions/1166880/should-tryfoo-ever-throw-an-exception
    // http://stackoverflow.com/questions/182440/tryparse-parse-like-pattern-what-is-the-best-way-to-implement-it
    public partial class NumberParser
    {
        public bool TryParse(string textToParse, out sbyte result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out sbyte result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out short result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out int result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, Scale.Short, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out long result)
        {
            return this.TryParse(textToParse, culture, Scale.Short, out result);
        }

        public bool TryParse(string textToParse, Scale scale, out long result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, scale, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, Scale scale, out long result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out byte result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out ushort result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out uint result)
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
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, Scale.Short, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, out ulong result)
        {
            return this.TryParse(textToParse, culture, Scale.Short, out result);
        }

        public bool TryParse(string textToParse, Scale scale, out ulong result)
        {
            return this.TryParse(textToParse, CultureInfo.CurrentCulture, scale, out result);
        }

        public bool TryParse(string textToParse, CultureInfo culture, Scale scale, out ulong result)
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
