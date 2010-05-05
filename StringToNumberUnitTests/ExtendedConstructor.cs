//-----------------------------------------------------------------------
// <copyright file="ExtendedConstructor.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Globalization;

namespace StringToNumberUnitTests
{
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class ExtendedConstructor
    {
        private NumberParser np;

        [Test]
        public void CustomGroupWord_IsValid()
        {
            this.np = new NumberParser(Scale.Short, new CultureInfo("en-GB"), new CustomWords(TypeOfWord.Group, "milliun", 1000000));
        
            int value;

            var result = this.np.TryToInt("milliun", out value);

            Assert.That(result, Is.EqualTo(true));
            Assert.That(value, Is.EqualTo(1000000));
        }
    }
}
