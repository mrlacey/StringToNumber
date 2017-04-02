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

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void MinusOneHundredAndTwentyNine_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for a signed byte."),
                          () => this.np.ToSByte("minus one hundred and twenty nine"));
        }

        [Test]
        public void MinusOneHundredAndTwentyEight_IsValid()
        {
            Assert.That(this.np.ToSByte("minus one hundred and twenty eight"), Is.EqualTo(-128));
        }

        [Test]
        public void FiftyTen_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToSByte("fifty ten"));
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

        [Test]
        public void OneHundredAndTwentyEight_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for a signed byte."),
                          () => this.np.ToSByte("one hundred and twenty eight"));
        }
    }
}
