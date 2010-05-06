//-----------------------------------------------------------------------
// <copyright file="NumberParser.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace StringToNumber
{
    /// <summary>
    /// Collection of logic for parsing strings to their equivalent numeric types
    /// </summary>
    public partial class NumberParser
    {
        /// <summary>
        /// Holds words and equivalent values of numbers under ten
        /// </summary>
        private readonly Hashtable units;

        /// <summary>
        /// Holds words and equivalent values of numbers between 10 and 19
        /// </summary>
        private readonly Hashtable teens;

        /// <summary>
        /// Holds words and equivalent values of numbers that are multiples of 10, between 20 and 90
        /// </summary>
        private readonly Hashtable multiplesOfTen;

        /// <summary>
        /// Holds words and equivalent values of numbers that can be considered multipliers, e.g. hundred, thousand, million
        /// </summary>
        private readonly Hashtable groups;

        /// <summary>
        /// List of words to treat as zero
        /// </summary>
        private readonly ArrayList zeros;

        /// <summary>
        /// List of words that are equivalent to one
        /// </summary>
        private readonly ArrayList ones;

        /// <summary>
        /// List of words which indicate a negative amount
        /// </summary>
        private readonly ArrayList negatives;

        /// <summary>
        /// List of words that are equivalent to 'and'
        /// </summary>
        private readonly ArrayList ands;

        /// <summary>
        /// List of characters that separate words. Also words and characters to ignore.
        /// </summary>
        private readonly string[] splitterChars;

        /// <summary>
        /// Internal record of the culture
        /// </summary>
        private readonly CultureInfo converterCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParser"/> class.
        /// Scale defaults to 'Scale.Short'
        /// Culture defaults to 'CultureInfo.CurrentCulture'
        /// </summary>
        public NumberParser()
            : this(Scale.Short, CultureInfo.CurrentCulture)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParser"/> class.
        /// Culture defaults to 'CultureInfo.CurrentCulture'
        /// </summary>
        /// <param name="scale">The large number scale to use.</param>
        public NumberParser(Scale scale)
            : this(scale, CultureInfo.CurrentCulture)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParser"/> class.
        /// Scale defaults to 'Scale.Short'
        /// </summary>
        /// <param name="culture">The culture indicating the language of text to convert.</param>
        public NumberParser(CultureInfo culture) : this(Scale.Short, culture, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParser"/> class.
        /// </summary>
        /// <param name="scale">The large number scale to use.</param>
        /// <param name="culture">The culture indicating the language of text to convert.</param>
        public NumberParser(Scale scale, CultureInfo culture) : this(scale, culture, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParser"/> class.
        /// </summary>
        /// <param name="scale">The large number scale to use.</param>
        /// <param name="culture">The culture indicating the language of text to convert.</param>
        /// <param name="customWords">Additional words to include as valid when processing.</param>
        public NumberParser(Scale scale, CultureInfo culture, params CustomWords[] customWords)
        {
            this.converterCulture = culture;

            // ToDo: inject this so can test resource loading and processing ?
            ResourceManager resMan = new ResourceManager(
                                          "StringToNumber.Properties.Resources",
                                          Assembly.GetExecutingAssembly());

            string splitChars = resMan.GetString("SplitterChars", this.converterCulture) ?? " ";

            this.splitterChars = splitChars.Split('|');

            /* IMPORTANT ! - Everything must be UPPER CASE */

            // N
            string negativeWords = resMan.GetString("NegativeWords", this.converterCulture) ?? string.Empty;
            this.negatives = new ArrayList(negativeWords.ToUpper(this.converterCulture).Split('|'));

            // A
            string andWords = resMan.GetString("AndWords", this.converterCulture) ?? string.Empty;
            this.ands = new ArrayList(andWords.ToUpper(this.converterCulture).Split('|'));

            // Z
            string zeroWords = resMan.GetString("ZeroWords", this.converterCulture) ?? string.Empty;
            this.zeros = new ArrayList(zeroWords.ToUpper(this.converterCulture).Split('|'));

            // S
            string singleWords = resMan.GetString("SingleWords", this.converterCulture) ?? string.Empty;
            this.ones = new ArrayList(singleWords.ToUpper(this.converterCulture).Split('|'));

            //// *** The following do actual substitutions ***

            // numbers which are valid by themselves
            // U
            string unitWordsAndValues = resMan.GetString("UnitWordsAndValues", this.converterCulture) ?? string.Empty;
            ArrayList unitsAndValues = new ArrayList(unitWordsAndValues.ToUpper(this.converterCulture).Split('|'));
            this.units = new Hashtable();

            foreach (string uav in unitsAndValues)
            {
                string[] unitDetails = uav.Split(':');
                this.units.Add(unitDetails[0], Decimal.Parse(unitDetails[1], this.converterCulture));
            }

            // ten through nineteen are special cases
            // T
            string teenWordsAndValues = resMan.GetString("TeenWordsAndValues", this.converterCulture) ?? string.Empty;
            ArrayList teensAndValues = new ArrayList(teenWordsAndValues.ToUpper(this.converterCulture).Split('|'));
            this.teens = new Hashtable();

            foreach (string tav in teensAndValues)
            {
                string[] teenDetails = tav.Split(':');
                this.teens.Add(teenDetails[0], Decimal.Parse(teenDetails[1], this.converterCulture));
            }

            // M
            string motWordsAndValues = resMan.GetString("MotWordsAndValues", CultureInfo.CurrentCulture) ?? string.Empty;
            ArrayList motAndValues = new ArrayList(motWordsAndValues.ToUpper(this.converterCulture).Split('|'));
            this.multiplesOfTen = new Hashtable();

            foreach (string mav in motAndValues)
            {
                string[] motDetails = mav.Split(':');
                this.multiplesOfTen.Add(motDetails[0], Decimal.Parse(motDetails[1], this.converterCulture));
            }

            // G
            ArrayList groupsAndValues;

            if (scale == Scale.Short)
            {
                string shortScaleGroups = resMan.GetString("ShortScaleGroups", this.converterCulture) ?? string.Empty;

                groupsAndValues = new ArrayList(shortScaleGroups.Split('|'));
            }
            else
            {
                string longScaleGroups = resMan.GetString("LongScaleGroups", this.converterCulture) ?? string.Empty;

                groupsAndValues = new ArrayList(longScaleGroups.Split('|'));
            }

            this.groups = new Hashtable();

            foreach (string gav in groupsAndValues)
            {
                string[] gutDetails = gav.Split(':');
                this.groups.Add(gutDetails[0], Decimal.Parse(gutDetails[1], this.converterCulture));
            }

            if (customWords != null)
            {
                foreach (var custom in customWords)
                {
                    switch (custom.WordType)
                    {
                        case TypeOfWord.And:
                            this.ands.Add(custom.Word.ToUpper(this.converterCulture));
                            break;
                        case TypeOfWord.Group:
                            this.groups.Add(custom.Word.ToUpper(this.converterCulture), custom.Value);
                            break;
                        case TypeOfWord.MultipleOfTen:
                            this.multiplesOfTen.Add(custom.Word.ToUpper(this.converterCulture), custom.Value);
                            break;
                        case TypeOfWord.Negative:
                            this.negatives.Add(custom.Word);
                            break;
                        case TypeOfWord.Single:
                            this.ones.Add(custom.Word.ToUpper(this.converterCulture));
                            break;
                        case TypeOfWord.Teen:
                            this.teens.Add(custom.Word.ToUpper(this.converterCulture), custom.Value);
                            break;
                        case TypeOfWord.Unit:
                            this.units.Add(custom.Word.ToUpper(this.converterCulture), custom.Value);
                            break;
                        case TypeOfWord.Zero:
                            this.zeros.Add(custom.Word.ToUpper(this.converterCulture));
                            break;
                    }
                }
            }
        }
    }
}