//-----------------------------------------------------------------------
// <copyright file="WordType.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumber
{
    /// <summary>
    /// Identifiers for the classification of valid input words.
    /// These are used in the regex as part of the text validation.
    /// </summary>
    internal static class WordType
    {
        /// <summary>
        /// Representation of a "word" that can be directly parsed as a number
        /// </summary>
        internal const char Parsed = 'P';

        /// <summary>
        /// Representation of a word that indicates the number is less than zero
        /// </summary>
        internal const char Negative = 'N';

        /// <summary>
        /// Representation of a combining word
        /// </summary>
        internal const char And = 'A';

        /// <summary>
        /// Representation of a word that indicates a number between 1 and 9
        /// </summary>
        internal const char Unit = 'U';

        /// <summary>
        /// Representation of a word that indicates one
        /// </summary>
        internal const char Single = 'S';

        /// <summary>
        /// Representation of a word that indicates a number between 10 and 19
        /// </summary>
        internal const char Teen = 'T';

        /// <summary>
        /// Representation of a word that indicates a number which is a multiple of ten, between 20 and 90
        /// </summary>
        internal const char MultipleOfTen = 'M';

        /// <summary>
        /// Representation of a word such as hundred, thousand, million, billion, etc.
        /// </summary>
        internal const char Group = 'G';

        /// <summary>
        /// Representation of a word that indicates zero
        /// </summary>
        internal const char Zero = 'Z';

        /// <summary>
        /// Representation of a word that indicates a number between 21 and 99 which is not a multiple of ten
        /// </summary>
        internal const string D21ThruD99 = "MU";
    }
}