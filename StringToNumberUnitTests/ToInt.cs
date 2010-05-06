//-----------------------------------------------------------------------
// <copyright file="ToInt.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
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
    public class ToInt
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        [Ignore("Support for digits appearing twice in a sentence is not yet supported")]
        public void D500TwentyD7_IsNotValid()
        {
            Assert.That(this.np.ToInt("500 twenty 7"), Is.EqualTo(527));
        }

        [Test]
        [Ignore("Support for digits appearing twice in a sentence is not yet supported")]
        public void D500AndTwentyD7_IsNotValid()
        {
            Assert.That(this.np.ToInt("500 and twenty 7"), Is.EqualTo(527));
        }

        [Test]
        public void D1500_IsValid()
        {
            Assert.That(this.np.ToInt("1500"), Is.EqualTo(1500));
        }

        [Test]
        public void D273000_IsValid()
        {
            Assert.That(this.np.ToInt("273000"), Is.EqualTo(273000));
        }

        [Test]
        public void MinusTwoBillionOneHundredAndFourtySevenMillionFourHundredAndEightyThreeThousandSixHundredAndFourtySeven_IsValid()
        {
            Assert.That(this.np.ToInt("minus two billion, one hundred and fourty seven million, four hundred and eighty three thousand, six hundred and fourty seven"), Is.EqualTo(-2147483647));
        }

        [Test]
        public void MinusThirtyTwoThousandSevenHundredAndSixtyNine_IsValid()
        {
            Assert.That(this.np.ToInt("minus thirty two thousand seven hundred and sixty nine"), Is.EqualTo(-32769));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void SixteenAndFour_IsNotValid()
        {
            Assert.That(this.np.ToInt("sixteen and four"), Is.EqualTo(164));
        }

        [Test]
        public void Fifty_Extension_IsValid()
        {
            Assert.That("fifty".ToInt(), Is.EqualTo(50));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void SixteenFifty_IsNotValid()
        {
            Assert.That(this.np.ToInt("sixteen fifty"), Is.EqualTo(1650));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void FourteenFour_IsNotValid()
        {
            Assert.That(this.np.ToInt("fourteen four"), Is.EqualTo(144));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void ElevenTwelve_IsNotValid()
        {
            Assert.That(this.np.ToInt("eleven twelve"), Is.EqualTo(17));
        }

        [Test]
        public void FourHundredThousand_IsValid()
        {
            Assert.That(this.np.ToInt("four hundred thousand"), Is.EqualTo(400000));
        }

        [Test]
        public void FourHundredAndTwentyThousand_IsValid()
        {
            Assert.That(this.np.ToInt("four hundred and twenty thousand"), Is.EqualTo(420000));
        }

        [Test]
        public void FourHundredThousandFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt("four hundred thousand five hundred"), Is.EqualTo(400500));
        }

        [Test]
        public void FiveHundredThousand_IsValid()
        {
            Assert.That(this.np.ToInt("five hundred thousand"), Is.EqualTo(500000));
        }

        [Test]
        public void Million_IsValid()
        {
            Assert.That(this.np.ToInt("million"), Is.EqualTo(1000000));
        }

        [Test]
        public void FifteenThousand_IsValid()
        {
            Assert.That(this.np.ToInt("fifteen thousand"), Is.EqualTo(15000));
        }

        [Test]
        public void FiftySpaceFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt("fifty five hundred"), Is.EqualTo(5500));
        }

        [Test]
        public void FiftyHyphenFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt("fifty-five hundred"), Is.EqualTo(5500));
        }

        [Test]
        public void FiftyFiveHundred_IsValid()
        {
            Assert.That(this.np.ToInt("fiftyfive hundred"), Is.EqualTo(5500));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void FiveThousandHundred_IsNotValid()
        {
            Assert.That(this.np.ToInt("five thousand hundred"), Is.EqualTo(500000));
        }

        public void TryFiveThousandHundred_HandlesInvalidCorrectly()
        {
            int value;

            Assert.That(this.np.TryToInt("five thousand hundred", out value), Is.EqualTo(false));
            Assert.That(value, Is.EqualTo(default(int)));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void TwoThousandThousand_IsNotValid()
        {
            Assert.That(this.np.ToInt("two thousand thousand"), Is.EqualTo(2000000));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void TwoMillionThousand_IsNotValid()
        {
            Assert.That(this.np.ToInt("two million thousand"), Is.EqualTo(2000000000));
        }

        [Test]
        public void TwoBillionOneHundredAndFourtySevenMillionFourHundredAndEightyThreeThousandSixHundredAndFourtySeven()
        {
            // 2,147,483,647
            Assert.That(this.np.ToInt("two billion, one hundred and fourty seven million, four hundred and eighty three thousand, six hundred and fourty seven"), Is.EqualTo(2147483647));
        }
    }
}
