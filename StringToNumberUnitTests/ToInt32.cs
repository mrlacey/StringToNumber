//-----------------------------------------------------------------------
// <copyright file="ToInt32.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
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
    public class ToInt32
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void TryPass_Five_Passes()
        {
            Int32 actual;

            var tryResult = this.np.TryToInt32("five", out actual);

            Assert.That(tryResult, Is.EqualTo(true));
            Assert.That(actual, Is.EqualTo(5));
        }

        [Test]
        public void TryPass_ZeroFive_Fails()
        {
            Int32 actual;

            var tryResult = this.np.TryToInt32("zero five", out actual);

            Assert.That(tryResult, Is.EqualTo(false));
            Assert.That(actual, Is.EqualTo(default(Int32)));
        }

        [Test]
        [Ignore("Support for digits appearing twice in a sentence is not yet supported")]
        public void D500TwentyD7_IsNotValid()
        {
            Assert.That(this.np.ToInt32("500 twenty 7"), Is.EqualTo(527));
        }

        [Test]
        [Ignore("Support for digits appearing twice in a sentence is not yet supported")]
        public void D500AndTwentyD7_IsNotValid()
        {
            Assert.That(this.np.ToInt32("500 and twenty 7"), Is.EqualTo(527));
        }

        [Test]
        public void D1500_IsValid()
        {
            Assert.That(this.np.ToInt32("1500"), Is.EqualTo(1500));
        }

        [Test]
        public void D273000_IsValid()
        {
            Assert.That(this.np.ToInt32("273000"), Is.EqualTo(273000));
        }

        [Test]
        public void MinusTwoBillionOneHundredAndFourtySevenMillionFourHundredAndEightyThreeThousandSixHundredAndFourtySeven_IsValid()
        {
            Assert.That(this.np.ToInt32("minus two billion, one hundred and fourty seven million, four hundred and eighty three thousand, six hundred and fourty seven"), Is.EqualTo(-2147483647));
        }

        [Test]
        public void MinusThirtyTwoThousandSevenHundredAndSixtyNine_IsValid()
        {
            Assert.That(this.np.ToInt32("minus thirty two thousand seven hundred and sixty nine"), Is.EqualTo(-32769));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void SixteenAndFour_IsNotValid()
        {
            Assert.That(this.np.ToInt32("sixteen and four"), Is.EqualTo(164));
        }

        [Test]
        public void Fifty_Extension_IsValid()
        {
            Assert.That("fifty".ToInt32(), Is.EqualTo(50));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void SixteenFifty_IsNotValid()
        {
            Assert.That(this.np.ToInt32("sixteen fifty"), Is.EqualTo(1650));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void FourteenFour_IsNotValid()
        {
            Assert.That(this.np.ToInt32("fourteen four"), Is.EqualTo(144));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void ElevenTwelve_IsNotValid()
        {
            Assert.That(this.np.ToInt32("eleven twelve"), Is.EqualTo(17));
        }

        [Test]
        public void FourHundredThousand_IsValid()
        {
            Assert.That(this.np.ToInt32("four hundred thousand"), Is.EqualTo(400000));
        }

        [Test]
        public void FourHundredAndTwentyThousand_IsValid()
        {
            Assert.That(this.np.ToInt32("four hundred and twenty thousand"), Is.EqualTo(420000));
        }

        [Test]
        public void FourHundredThousandFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt32("four hundred thousand five hundred"), Is.EqualTo(400500));
        }

        [Test]
        public void FiveHundredThousand_IsValid()
        {
            Assert.That(this.np.ToInt32("five hundred thousand"), Is.EqualTo(500000));
        }

        [Test]
        public void Million_IsValid()
        {
            Assert.That(this.np.ToInt32("million"), Is.EqualTo(1000000));
        }

        [Test]
        public void FifteenThousand_IsValid()
        {
            Assert.That(this.np.ToInt32("fifteen thousand"), Is.EqualTo(15000));
        }

        [Test]
        public void FiftySpaceFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt32("fifty five hundred"), Is.EqualTo(5500));
        }

        [Test]
        public void FiftyHyphenFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt32("fifty-five hundred"), Is.EqualTo(5500));
        }

        [Test]
        public void FiftyFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt32("fiftyfive hundred"), Is.EqualTo(5500));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void FiveThousandHundred_IsNotValid()
        {
            Assert.That(this.np.ToInt32("five thousand hundred"), Is.EqualTo(500000));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void TwoThousandThousand_IsNotValid()
        {
            Assert.That(this.np.ToInt32("two thousand thousand"), Is.EqualTo(2000000));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void TwoMillionThousand_IsNotValid()
        {
            Assert.That(this.np.ToInt32("two million thousand"), Is.EqualTo(2000000000));
        }

        [Test]
        public void TwoBillionOneHundredAndFourtySevenMillionFourHundredAndEightyThreeThousandSixHundredAndFourtySeven()
        {
            Assert.That(this.np.ToInt32("two billion, one hundred and fourty seven million, four hundred and eighty three thousand, six hundred and fourty seven"), Is.EqualTo(2147483647));
        }
    }
}
