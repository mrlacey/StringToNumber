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
    public class ToUInt
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for a UInt32.")]
        public void MinusOne_IsNotValid()
        {
            Assert.That(this.np.ToUInt("minus one"), Is.EqualTo(-1));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        [Category("Debatable")]
        public void MinusZero_IsNotValid()
        {
            Assert.That(this.np.ToUInt("minus zero"), Is.EqualTo(-0));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToUInt("zero"), Is.EqualTo(0));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToUInt(), Is.EqualTo((uint)5));
        }

        [Test]
        public void FiveThousand_IsValid()
        {
            Assert.That(this.np.ToUInt("five thousand"), Is.EqualTo(5000));
        }

        [Test]
        public void TenThousand_IsValid()
        {
            Assert.That(this.np.ToUInt("ten thousand"), Is.EqualTo(10000));
        }

        [Test]
        public void FifteenThousand_IsValid()
        {
            Assert.That(this.np.ToUInt("fifteen thousand"), Is.EqualTo(15000));
        }

        [Test]
        public void FifteenThousandAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt("fifteen thousand and thirty five"), Is.EqualTo(15035));
        }

        [Test]
        public void FifteenThousandThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt("fifteen thousand thirty five"), Is.EqualTo(15035));
        }

        [Test]
        public void FifteenThousandFiveHundred_IsValid()
        {
            Assert.That(this.np.ToUInt("fifteen thousand five hundred"), Is.EqualTo(15500));
        }

        [Test]
        public void FifteenThousandFiveHundredAndThirtyFive_IsValid()
        {
            Assert.That(this.np.ToUInt("fifteen thousand five hundred and thirty five"), Is.EqualTo(15535));
        }

        [Test]
        public void SixtyThousand_IsValid()
        {
            Assert.That(this.np.ToUInt("sixty thousand"), Is.EqualTo(60000));
        }

        [Test]
        public void SixtyFiveThousand_IsValid()
        {
            Assert.That(this.np.ToUInt("sixty five thousand"), Is.EqualTo(65000));
        }

        [Test]
        public void FourBillionTwoHundredAndNinetyFourMillionNineHundredAndSixtySevenThousandTwoHundredAndNinetyFive_IsValid()
        {
            Assert.That(this.np.ToUInt("Four Billion, Two Hundred And Ninety-Four Million, Nine Hundred And Sixty Seven Thousand Two Hundred & Ninety Five"), Is.EqualTo(4294967295));
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for a UInt32.")]
        public void FourBillionTwoHundredAndNinetyFourMillionNineHundredAndSixtySevenThousandTwoHundredAndNinetySix_IsNotValid()
        {
            Assert.That(this.np.ToUInt("Four Billion, Two Hundred And Ninety-Four Million, Nine Hundred And Sixty Seven Thousand Two Hundred & Ninety Six"), Is.EqualTo(4294967296));
        }
    }
}
