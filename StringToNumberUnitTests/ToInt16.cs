//-----------------------------------------------------------------------
// <copyright file="ToInt16.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests
{
    using System;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class ToInt16
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for an Int16.")]
        public void MinusThirtyTwoThousandSevenHundredAndSixtyNine_IsNotValid()
        {
            Assert.That(this.np.ToInt16("minus thirty two thousand seven hundred and sixty nine"), Is.EqualTo(-32769));
        }

        [Test]
        public void MinusThirtyTwoThousandSevenHundredAndSixtyEight_IsValid()
        {
            Assert.That(this.np.ToInt16("minus thirty two thousand seven hundred and sixty eight"), Is.EqualTo(-32768));
        }

        [Test]
        public void MinusOne_IsValid()
        {
            Assert.That(this.np.ToInt16("minus one"), Is.EqualTo(-1));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToInt16("zero"), Is.EqualTo(0));
        }

        [Test]
        public void One_IsValid()
        {
            Assert.That(this.np.ToInt16("one"), Is.EqualTo(1));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToInt16(), Is.EqualTo((Int16)5));
        }

        [Test]
        public void ThirtyTwoThousandSevenHundredAndSixtySeven_IsValid()
        {
            Assert.That(this.np.ToInt16("thirty two thousand seven hundred and sixty seven"), Is.EqualTo(32767));
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for an Int16.")]
        public void ThirtyTwoThousandSevenHundredAndSixtyEight_IsNotValid()
        {
            Assert.That(this.np.ToInt16("thirty two thousand seven hundred and sixty eight"), Is.EqualTo(32768));
        }
    }
}
