//-----------------------------------------------------------------------
// <copyright file="ToByte.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
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
    public class ToByte
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Short);
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for an unsigned byte.")]
        public void MinusOne_IsNotValid()
        {
            Assert.That(this.np.ToByte("minus one"), Is.EqualTo(-1));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToByte("zero"), Is.EqualTo(0));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("five".ToByte(), Is.EqualTo((byte)5));
        }

        [Test]
        public void Five_IsValid()
        {
            Assert.That(this.np.ToByte("five"), Is.EqualTo(5));
        }

        [Test]
        public void D5_IsValid()
        {
            Assert.That(this.np.ToByte("5"), Is.EqualTo(5));
        }

        [Test]
        public void Sixteen_IsValid()
        {
            Assert.That(this.np.ToByte("Sixteen"), Is.EqualTo(16));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void SevenTen_IsNotValid()
        {
            Assert.That(this.np.ToByte("seven ten"), Is.EqualTo(17));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        [Category("Debatable")]
        public void ZeroFive_IsNotValid()
        {
            Assert.That(this.np.ToByte("zero five"), Is.EqualTo(5));
        }

        [Test]
        public void TryPass_Five_Passes()
        {
            byte actual;

            var tryResult = this.np.TryToByte("five", out actual);

            Assert.That(tryResult, Is.EqualTo(true));
            Assert.That(actual, Is.EqualTo((byte)5));
        }

        [Test]
        public void TryPass_ZeroFive_Fails()
        {
            byte actual;

            var tryResult = this.np.TryToByte("zero five", out actual);

            Assert.That(tryResult, Is.EqualTo(false));
            Assert.That(actual, Is.EqualTo(default(byte)));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void SevenThirteen_IsNotValid()
        {
            Assert.That(this.np.ToByte("seven thirteen"), Is.EqualTo(713));
        }

        [Test]
        public void Thirty_IsValid()
        {
            Assert.That(this.np.ToByte("Thirty"), Is.EqualTo(30));
        }

        [Test]
        public void FiftyFiveNoSpace_IsValid()
        {
            Assert.That(this.np.ToByte("FiftyFive"), Is.EqualTo(55));
        }

        [Test]
        public void SeventyFour_IsValid()
        {
            Assert.That(this.np.ToByte("seventy four"), Is.EqualTo(74));
        }

        [Test]
        public void SeventyHyphenFour_IsValid()
        {
            Assert.That(this.np.ToByte("seventy-four"), Is.EqualTo(74));
        }

        [Test]
        public void Hundred_IsValid()
        {
            Assert.That(this.np.ToByte("hundred"), Is.EqualTo(100));
        }

        [Test]
        public void HundredAndTwo_IsValid()
        {
            Assert.That(this.np.ToByte("hundred and two"), Is.EqualTo(102));
        }

        [Test]
        public void HundredAndTwenty_IsValid()
        {
            Assert.That(this.np.ToByte("hundred and twenty"), Is.EqualTo(120));
        }

        [Test]
        public void AHundred_IsValid()
        {
            Assert.That(this.np.ToByte("a hundred"), Is.EqualTo(100));
        }

        [Test]
        public void OneHundred_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred"), Is.EqualTo(100));
        }

        [Test]
        public void D1Hundred_IsValid()
        {
            Assert.That(this.np.ToByte("1 hundred"), Is.EqualTo(100));
        }

        [Test]
        public void OneHundredAndFive_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred and five"), Is.EqualTo(105));
        }

        [Test]
        public void AnHundredAndFive_IsValid()
        {
            Assert.That(this.np.ToByte("an hundred and five"), Is.EqualTo(105));
        }

        [Test]
        public void OneHundredAndD5_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred and 5"), Is.EqualTo(105));
        }

        [Test]
        public void OneHundredFive_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred five"), Is.EqualTo(105));
        }

        [Test]
        public void OneHundredAndFifteen_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred and fifteen"), Is.EqualTo(115));
        }

        [Test]
        public void OneHundredFifteen_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred fifteen"), Is.EqualTo(115));
        }

        [Test]
        public void OneHundredAndD15_IsValid()
        {
            Assert.That(this.np.ToByte("one hundred and 15"), Is.EqualTo(115));
        }

        [Test]
        public void TwoHundredFifty_IsValid()
        {
            Assert.That(this.np.ToByte("two hundred fifty"), Is.EqualTo(250));
        }

        [Test]
        public void TwoHundredAndFifty_IsValid()
        {
            Assert.That(this.np.ToByte("two hundred and fifty"), Is.EqualTo(250));
        }

        [Test]
        public void TwoHundredD50_IsValid()
        {
            Assert.That(this.np.ToByte("two hundred 50"), Is.EqualTo(250));
        }

        [Test]
        public void TwoHundredFiftyFive_IsValid()
        {
            Assert.That(this.np.ToByte("two hundred fifty five"), Is.EqualTo(255));
        }

        [Test]
        public void TwoHundredAndFiftyFive_IsValid()
        {
            Assert.That(this.np.ToByte("two hundred and fifty five"), Is.EqualTo(255));
        }

        [Test]
        public void TwoHundredAndD55_IsValid()
        {
            Assert.That(this.np.ToByte("two hundred and 55"), Is.EqualTo(255));
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for an unsigned byte.")]
        public void TwoHundredAndFiftySix_IsNotValid()
        {
            Assert.That(this.np.ToByte("two hundred and fifty six"), Is.EqualTo(256));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitSpaceUnit_IsNotValid()
        {
            Assert.That(this.np.ToByte("five five"), Is.EqualTo(55));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitSpaceD5_IsNotValid()
        {
            Assert.That(this.np.ToByte("five 5"), Is.EqualTo(55));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void D5SpaceUnit_IsNotValid()
        {
            Assert.That(this.np.ToByte("5 five"), Is.EqualTo(55));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void D5SpaceD5_IsNotValid()
        {
            Assert.That(this.np.ToByte("5 5"), Is.EqualTo(55));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitTen_IsNotValid()
        {
            Assert.That(this.np.ToByte("five ten"), Is.EqualTo(510));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitUnit_IsNotValid()
        {
            Assert.That(this.np.ToByte("five six"), Is.EqualTo(56));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitAnd_IsNotValid()
        {
            Assert.That(this.np.ToByte("five &"), Is.EqualTo(5));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitSingle_IsNotValid()
        {
            Assert.That(this.np.ToByte("five An"), Is.EqualTo(5));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void UnitNegative_IsNotValid()
        {
            Assert.That(this.np.ToByte("five Minus"), Is.EqualTo(-5));
        }
    }
}
