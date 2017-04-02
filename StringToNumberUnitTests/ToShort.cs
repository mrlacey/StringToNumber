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
    public class ToShort
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void MinusThirtyTwoThousandSevenHundredAndSixtyNine_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for an Int16."),
                          () => this.np.ToShort("minus thirty two thousand seven hundred and sixty nine"));
        }

        [Test]
        public void MinusThirtyTwoThousandSevenHundredAndSixtyEight_IsValid()
        {
            Assert.That(this.np.ToShort("minus thirty two thousand seven hundred and sixty eight"), Is.EqualTo(-32768));
        }

        [Test]
        public void MinusOne_IsValid()
        {
            Assert.That(this.np.ToShort("minus one"), Is.EqualTo(-1));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToShort("zero"), Is.EqualTo(0));
        }

        [Test]
        public void One_IsValid()
        {
            Assert.That(this.np.ToShort("one"), Is.EqualTo(1));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToShort(), Is.EqualTo((Int16)5));
        }

        [Test]
        public void ThirtyTwoThousandSevenHundredAndSixtySeven_IsValid()
        {
            Assert.That(this.np.ToShort("thirty two thousand seven hundred and sixty seven"), Is.EqualTo(32767));
        }

        [Test]
        public void ThirtyTwoThousandSevenHundredAndSixtyEight_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for an Int16."),
                          () => this.np.ToShort("thirty two thousand seven hundred and sixty eight"));
        }
    }
}
