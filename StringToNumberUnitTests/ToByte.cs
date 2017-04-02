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

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Short);
        }

        [Test]
        public void MinusOne_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>()
                  .And.Message.EqualTo("Value was either too large or too small for an unsigned byte."),
                  () => this.np.ToByte("minus one"));
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

        [Test]
        public void SevenTen_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
               () => this.np.ToByte("seven ten"));
        }

        [Test]
        [Category("Debatable")]
        public void ZeroFive_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("zero five"));
        }

        [Test]
        public void TryPass_Five_Passes()
        {
            var tryResult = this.np.TryToByte("five", out byte actual);

            Assert.That(tryResult, Is.EqualTo(true));
            Assert.That(actual, Is.EqualTo((byte)5));
        }

        [Test]
        public void TryPass_ZeroFive_Fails()
        {
            var tryResult = this.np.TryToByte("zero five", out byte actual);

            Assert.That(tryResult, Is.EqualTo(false));
            Assert.That(actual, Is.EqualTo(default(byte)));
        }

        [Test]
        public void SevenThirteen_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("seven thirteen"));
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

        [Test]
        public void TwoHundredAndFiftySix_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>().
                          And.Message.EqualTo("Value was either too large or too small for an unsigned byte."),
                          () => this.np.ToByte("two hundred and fifty six"));
        }

        [Test]
        public void UnitSpaceUnit_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five five"));
        }

        [Test]
        public void UnitSpaceD5_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five 5"));
        }

        [Test]
        public void D5SpaceUnit_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("5 five"));
        }

        [Test]
        public void D5SpaceD5_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("5 5"));
        }

        [Test]
        public void UnitTen_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five ten"));
        }

        [Test]
        public void UnitUnit_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five six"));
        }

        [Test]
        public void UnitAnd_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five &"));
        }

        [Test]
        public void UnitSingle_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five An"));
        }

        [Test]
        public void UnitNegative_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToByte("five Minus"));
        }
    }
}
