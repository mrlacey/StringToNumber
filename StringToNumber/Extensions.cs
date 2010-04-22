//-----------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace StringToNumber
{
    /// <summary>
    /// Extension methods implementing the StringToNumber functionality
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts the string to a byte.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a byte</returns>
        public static byte ToByte(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToByte(words);
        }

        /// <summary>
        /// Converts the string to a byte.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a byte</returns>
        public static byte ToByte(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToByte(words);
        }

        /// <summary>
        /// Converts the string to a signed byte.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a sbyte</returns>
        public static sbyte ToSByte(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToSByte(words);
        }

        /// <summary>
        /// Converts the string to a signed byte.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a sbyte</returns>
        public static sbyte ToSByte(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToSByte(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 16bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a UInt16</returns>
        public static UInt16 ToUInt16(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToUInt16(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 16 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a UInt16</returns>
        public static UInt16 ToUInt16(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToUInt16(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 32bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a UInt32</returns>
        public static UInt32 ToUInt32(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToUInt32(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 32 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a UInt32</returns>
        public static UInt32 ToUInt32(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToUInt32(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 32bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a UInt</returns>
        public static uint ToUInt(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToUInt(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 32 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a UInt</returns>
        public static uint ToUInt(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToUInt(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 64bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a UInt64</returns>
        public static UInt64 ToUInt64(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToUInt64(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a UInt64</returns>
        public static UInt64 ToUInt64(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToUInt64(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <returns>The value as an Int64</returns>
        public static UInt64 ToUInt64(this string words, Scale scale)
        {
            return new NumberParser(scale, CultureInfo.CurrentCulture).ToUInt64(words);
        }

        /// <summary>
        /// Converts the string to an unsigned 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int64</returns>
        public static UInt64 ToUInt64(this string words, Scale scale, CultureInfo culture)
        {
            return new NumberParser(scale, culture).ToUInt64(words);
        }

        /// <summary>
        /// Converts the string to an unsigned short.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a ushort</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "ushort", Justification = "Deliberately also including type names to provide more usage options")]
        public static ushort ToUShort(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToUShort(words);
        }

        /// <summary>
        /// Converts the string to an unsigned short.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a ushort</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "ushort", Justification = "Deliberately also including type names to provide more usage options")]
        public static ushort ToUShort(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToUShort(words);
        }

        /// <summary>
        /// Converts the string to a 16 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as an Int16</returns>
        public static Int16 ToInt16(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToInt16(words);
        }

        /// <summary>
        /// Converts the string to a 16 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int16</returns>
        public static Int16 ToInt16(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToInt16(words);
        }

        /// <summary>
        /// Converts the string to a short.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as a short</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "short", Justification = "Deliberately also including type names to provide more usage options")]
        public static short ToShort(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToShort(words);
        }

        /// <summary>
        /// Converts the string to a short.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a short</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "short", Justification = "Deliberately also including type names to provide more usage options")]
        public static short ToShort(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToShort(words);
        }

        /// <summary>
        /// Converts the string to a 32 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as an Int32</returns>
        public static Int32 ToInt32(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToInt32(words);
        }

        /// <summary>
        /// Converts the string to a 32 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int32</returns>
        public static Int32 ToInt32(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToInt32(words);
        }

        /// <summary>
        /// Converts the string to a long.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as an Int64</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "long", Justification = "Deliberately also including type names to provide more usage options")]
        public static long ToLong(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToLong(words);
        }

        /// <summary>
        /// Converts the string to a long.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int64</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "long", Justification = "Deliberately also including type names to provide more usage options")]
        public static long ToLong(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToLong(words);
        }

        /// <summary>
        /// Converts the string to a long.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <returns>The value as an Int64</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "long", Justification = "Deliberately also including type names to provide more usage options")]
        public static long ToLong(this string words, Scale scale)
        {
            return new NumberParser(scale, CultureInfo.CurrentCulture).ToLong(words);
        }

        /// <summary>
        /// Converts the string to a long.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int64</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "long", Justification = "Deliberately also including type names to provide more usage options")]
        public static long ToLong(this string words, Scale scale, CultureInfo culture)
        {
            return new NumberParser(scale, culture).ToLong(words);
        }

        /// <summary>
        /// Converts the string to a 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as an Int64</returns>
        public static Int64 ToInt64(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToInt64(words);
        }

        /// <summary>
        /// Converts the string to a 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int64</returns>
        public static Int64 ToInt64(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToInt64(words);
        }

        /// <summary>
        /// Converts the string to a 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <returns>The value as an Int64</returns>
        public static Int64 ToInt64(this string words, Scale scale)
        {
            return new NumberParser(scale, CultureInfo.CurrentCulture).ToInt64(words);
        }

        /// <summary>
        /// Converts the string to a 64 bit Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an Int64</returns>
        public static Int64 ToInt64(this string words, Scale scale, CultureInfo culture)
        {
            return new NumberParser(scale, culture).ToInt64(words);
        }

        /// <summary>
        /// Converts the string to an Integer.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <returns>The value as an int</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "int", Justification = "Deliberately also including type names to provide more usage options")]
        public static int ToInt(this string words)
        {
            return new NumberParser(CultureInfo.CurrentCulture).ToInt(words);
        }

        /// <summary>
        /// Converts the string to an Integer.
        /// </summary>
        /// <param name="words">The text to convert.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as an int</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "int", Justification = "Deliberately also including type names to provide more usage options")]
        public static int ToInt(this string words, CultureInfo culture)
        {
            return new NumberParser(culture).ToInt(words);
        }

        /// <summary>
        /// Converts the string to an unsigned long.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <returns>The value as a ulong</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "ulong", Justification = "Deliberately also including type names to provide more usage options")]
        public static ulong ToULong(this string words, Scale scale)
        {
            return new NumberParser(scale, CultureInfo.CurrentCulture).ToULong(words);
        }

        /// <summary>
        /// Converts the string to an unsigned long.
        /// </summary>
        /// <param name="words">The words to convert.</param>
        /// <param name="scale">The numeric scale to use when interpreting large numbers.</param>
        /// <param name="culture">The culture identifying the language the words are written in.</param>
        /// <returns>The value as a ulong</returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "ulong", Justification = "Deliberately also including type names to provide more usage options")]
        public static ulong ToULong(this string words, Scale scale, CultureInfo culture)
        {
            return new NumberParser(scale, culture).ToULong(words);
        }
    }
}