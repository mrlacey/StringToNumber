//-----------------------------------------------------------------------
// <copyright file="ParseWords.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests.Internals
{
    using System.Collections;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class ParseWords
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void One_ParsesCorrectly()
        {
            var words = new[] { "ONE" };

            this.np.ParseWords(words, false, out string pattern, out ArrayList parsedWords, out ArrayList numerics);

            var expectedParsedWords = new ArrayList { "ONE" };
            var expectedNumerics = new ArrayList();

            Assert.That(pattern, Is.EqualTo("U"));
            Assert.That(parsedWords, Is.EqualTo(expectedParsedWords));
            Assert.That(numerics, Is.EqualTo(expectedNumerics));
        }

        [Test]
        public void D1_ParsesCorrectly()
        {
            var words = new[] { "1" };

            this.np.ParseWords(words, false, out string pattern, out ArrayList parsedWords, out ArrayList numerics);

            var expectedParsedWords = new ArrayList { "1" };
            var expectedNumerics = new ArrayList();

            Assert.That(pattern, Is.EqualTo("U"));
            Assert.That(parsedWords, Is.EqualTo(expectedParsedWords));
            Assert.That(numerics, Is.EqualTo(expectedNumerics));
        }

        [Test]
        [Ignore("Support for digits appearing twice in a sentence is not yet supported")]
        public void D500AndTwentyD7_ParsesCorrectly()
        {
            var words = new[] { "500", "AND", "TWENTY", "7" };

            this.np.ParseWords(words, false, out string pattern, out ArrayList parsedWords, out ArrayList numerics);

            var expectedParsedWords = new ArrayList { "500", "AND", "TWENTY", "7" };

            // This isn't valid
            var expectedNumerics = new ArrayList { 500, 0, 0, 7 };

            Assert.That(pattern, Is.EqualTo("PAMU"));
            Assert.That(parsedWords, Is.EqualTo(expectedParsedWords));
            Assert.That(numerics, Is.EqualTo(expectedNumerics));
        }
    }
}
