//-----------------------------------------------------------------------
// <copyright file="ToUInt16.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
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
    public class ToUShort
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void MinusOne_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for a UInt16."),
                          () => this.np.ToUShort("minus one"));
        }

        [Test]
        [Category("Debatable")]
        public void MinusZero_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToUShort("minus zero"));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToUShort("zero"), Is.EqualTo(0));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToUShort(), Is.EqualTo((ushort)5));
        }

        [Test]
        public void FiveThousand_IsValid()
        {
            Assert.That(this.np.ToUShort("five thousand"), Is.EqualTo(5000));
        }

        [Test]
        public void TenThousand_IsValid()
        {
            Assert.That(this.np.ToUShort("ten thousand"), Is.EqualTo(10000));
        }

        [Test]
        public void FifteenThousand_IsValid()
        {
            Assert.That(this.np.ToUShort("fifteen thousand"), Is.EqualTo(15000));
        }

        [Test]
        public void FifteenThousandAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUShort("fifteen thousand and thirty five"), Is.EqualTo(15035));
        }

        [Test]
        public void FifteenThousandThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUShort("fifteen thousand thirty five"), Is.EqualTo(15035));
        }

        [Test]
        public void FifteenThousandFiveHundred_IsValid()
        {
            Assert.That(this.np.ToUShort("fifteen thousand five hundred"), Is.EqualTo(15500));
        }

        [Test]
        public void FifteenThousandFiveHundredAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUShort("fifteen thousand five hundred and thirty five"), Is.EqualTo(15535));
        }

        [Test]
        public void SixtyThousand_IsValid()
        {
            Assert.That(this.np.ToUShort("sixty thousand"), Is.EqualTo(60000));
        }

        [Test]
        public void SixtyFiveThousand_IsValid()
        {
            Assert.That(this.np.ToUShort("sixty five thousand"), Is.EqualTo(65000));
        }

        [Test]
        public void SixtyFiveThousandFiveHundredAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUShort("sixty five thousand five hundred and thirty five"), Is.EqualTo(65535));
        }

        [Test]
        public void SixtyFiveThousandFiveHundredAndThirtySix_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for a UInt16."),
                          () => this.np.ToUShort("sixty five thousand five hundred and thirty six"));
        }
    }
}
