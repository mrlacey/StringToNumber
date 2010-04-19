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
    public class ToUInt64
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for a UInt64.")]
        public void MinusOne_IsNotValid()
        {
            Assert.That(this.np.ToUInt64("minus one"), Is.EqualTo(-1));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        [Category("Debatable")]
        public void MinusZero_IsNotValid()
        {
            Assert.That(this.np.ToUInt64("minus zero"), Is.EqualTo(-0));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToUInt64("zero"), Is.EqualTo(0));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToUInt64(), Is.EqualTo((UInt64)5));
        }

        [Test]
        public void FiveThousand_IsValid()
        {
            Assert.That(this.np.ToUInt64("five thousand"), Is.EqualTo(5000));
        }

        [Test]
        public void TenThousand_IsValid()
        {
            Assert.That(this.np.ToUInt64("ten thousand"), Is.EqualTo(10000));
        }

        [Test]
        public void FifteenThousand_IsValid()
        {
            Assert.That(this.np.ToUInt64("fifteen thousand"), Is.EqualTo(15000));
        }

        [Test]
        public void FifteenThousandAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt64("fifteen thousand and thirty five"), Is.EqualTo(15035));
        }

        [Test]
        public void FifteenThousandThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt64("fifteen thousand thirty five"), Is.EqualTo(15035));
        }

        [Test]
        public void FifteenThousandFiveHundred_IsValid()
        {
            Assert.That(this.np.ToUInt64("fifteen thousand five hundred"), Is.EqualTo(15500));
        }

        [Test]
        public void FifteenThousandFiveHundredAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt64("fifteen thousand five hundred and thirty five"), Is.EqualTo(15535));
        }

        [Test]
        public void SixtyThousand_IsValid()
        {
            Assert.That(this.np.ToUInt64("sixty thousand"), Is.EqualTo(60000));
        }

        [Test]
        public void SixtyFiveThousand_IsValid()
        {
            Assert.That(this.np.ToUInt64("sixty five thousand"), Is.EqualTo(65000));
        }

        [Test]
        public void SixtyFiveThousandFiveHundredAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt64("sixty five thousand five hundred and thirty five"), Is.EqualTo(65535));
        }

        [Ignore("Currently not supporting anything larger than Int64.Max (9223372036854775807)")]
        [Test]
        public void EighteenQuintillion_IsValid()
        {
            Assert.That(this.np.ToUInt64("Eighteen Quintillion"), Is.EqualTo(18000000000000000000));
        }
        ////18 446 744 073 709 551 615
        ////     8 000 000 000 000 000
        //[Test]
        //public void SixtyFiveThousandFiveHundredAndThirtyFiveX_IsValid()
        //{
        //    Assert.That(this.np.ToUInt64("sixty five thousand five hundred and thirty five"), Is.EqualTo(18446744073709551615));
        //}

        //[Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for a UInt64.")]
        //public void SixtyFiveThousandFiveHundredAndThirtySix_IsNotValid()
        //{
        //    Assert.That(this.np.ToUInt64("sixty five thousand five hundred and thirty six"), Is.EqualTo(0)); //18446744073709551616
        //}
    }
}
