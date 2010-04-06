//-----------------------------------------------------------------------
// <copyright file="ToSByte.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests
{
    using System;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class ToSByte
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for a signed byte.")]
        public void MinusOneHundredAndTwentyNine_IsNotValid()
        {
            Assert.That(this.np.ToSByte("minus one hundred and twenty nine"), Is.EqualTo(-129));
        }

        [Test]
        public void MinusOneHundredAndTwentyEight_IsValid()
        {
            Assert.That(this.np.ToSByte("minus one hundred and twenty eight"), Is.EqualTo(-128));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void FiftyTen_IsNotValid()
        {
            Assert.That(this.np.ToSByte("fifty ten"), Is.EqualTo(5010));
        }

        [Test]
        public void MinusOne_IsValid()
        {
            Assert.That(this.np.ToSByte("minus one"), Is.EqualTo(-1));
        }

        [Test]
        public void MinusD1_IsValid()
        {
            Assert.That(this.np.ToSByte("minus 1"), Is.EqualTo(-1));
        }

        [Test]
        public void DMinus1_IsValid()
        {
            Assert.That(this.np.ToSByte("-1"), Is.EqualTo(-1));
        }

        [Test]
        public void NegativeOne_IsValid()
        {
            Assert.That(this.np.ToSByte("negative one"), Is.EqualTo(-1));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToSByte("zero"), Is.EqualTo(0));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToSByte(), Is.EqualTo((byte)5));
        }

        [Test]
        public void OneHundredAndTwentySeven_IsValid()
        {
            Assert.That(this.np.ToSByte("one hundred and twenty seven"), Is.EqualTo(127));
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for a signed byte.")]
        public void OneHundredAndTwentyEight_IsNotValid()
        {
            Assert.That(this.np.ToSByte("one hundred and twenty eight"), Is.EqualTo(128));
        }
    }
}
