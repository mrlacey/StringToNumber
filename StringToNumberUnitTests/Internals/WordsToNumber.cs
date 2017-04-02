//-----------------------------------------------------------------------
// <copyright file="WordsToNumber.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests.Internals
{
    using System;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class WordsToNumber
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void TryingToParseNull_IsNotValid()
        {
            Assert.Throws<ArgumentNullException>(
                  () => this.np.WordsToNumber(null));
        }

        [Test]
        public void TryingToParseEmptyString_IsNotValid()
        {
            Assert.Throws<ArgumentException>(
                  () => this.np.WordsToNumber(string.Empty));
        }

        [Test]
        public void TryingToParseWhiteSpace_ReturnsError()
        {
            Assert.Throws<ArgumentException>(
                  () => this.np.WordsToNumber(" "));
        }

        [Test]
        public void TryingToParseNull_UsingTry_ReturnsZeroAndNoError()
        {
            var err = this.np.WordsToNumber(null, false);

            Assert.That(err, Is.EqualTo(0));
        }

        [Test]
        public void TryingToParseEmptyString_UsingTry_ReturnsZeroAndNoError()
        {
            var err = this.np.WordsToNumber(string.Empty, false);

            Assert.That(err, Is.EqualTo(0));
        }

        [Test]
        public void TryingToParseWhiteSpace_UsingTry_ReturnsZeroAndNoError()
        {
            var err = this.np.WordsToNumber("  ", false);

            Assert.That(err, Is.EqualTo(0));
        }
    }
}
