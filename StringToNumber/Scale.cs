//-----------------------------------------------------------------------
// <copyright file="Scale.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumber
{
    /// <summary>
    /// Numeric scale.
    /// For more info see: http://en.wikipedia.org/wiki/Names_of_large_numbers
    /// </summary>
    public enum Scale
    {
        /// <summary>
        /// As used in USA and Modern British - Billion = 10^9
        /// </summary>
        Short,

        /// <summary>
        /// As used in Continental Europe and Traditional British - Billion = 10^12
        /// </summary>
        Long
    }
}