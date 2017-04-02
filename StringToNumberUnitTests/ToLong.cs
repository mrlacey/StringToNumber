//-----------------------------------------------------------------------
// <copyright file="ToInt64.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
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
    public class ToLong
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser();
        }

        [Test]
        public void SevenMillionThousand_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToLong("seven million thousand"));
        }

        public void TwoBillionSixMillion()
        {
            Assert.That(this.np.ToLong("two billion six million"), Is.EqualTo(2006000000));
        }

        [Test]
        public void TwoBillionAndSixMillion_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToLong("two billion and six million"));
        }

        [Test]
        public void TwoTrillionAndEighteen_IsValid()
        {
            Assert.That(this.np.ToLong("two trillion and eighteen"), Is.EqualTo(2000000000018));
        }

        [Test]
        [Category("Debatable")]
        public void EightHundredSevenBillion_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToLong("eight hundred seven billion"));
        }

        [Test]
        [Category("Debatable")]
        public void ZeroMillion_IsNotValid()
        {
            Assert.Throws<InvalidCastException>(
                () => this.np.ToLong("zero million"));
        }

        [Test]
        public void EightHundredAndSevenBillion_IsValid()
        {
            Assert.That(this.np.ToLong("eight hundred and seven billion"), Is.EqualTo(807000000000));
        }

        [Test]
        public void EightHundredAndSevenBillionAndOne_IsValid()
        {
            Assert.That(this.np.ToLong("eight hundred and seven billion and one"), Is.EqualTo(807000000001));
        }

        [Test]
        public void EightHundredAndSixtyFourBillion_IsValid()
        {
            Assert.That(this.np.ToLong("eight hundred and sixty four billion"), Is.EqualTo(864000000000));
        }

        [Test]
        public void TwoTrillionThreeBillionFourMillionFiveThousandSixHundred_IsValid()
        {
            Assert.That(this.np.ToLong("two trillion three billion four million five thousand six hundred"), Is.EqualTo(2003004005600));
        }

        [Test]
        public void EightyFiveTrillionCommaThirtyTwoBillionCommaSixHundredAndSeventyFourMillionCommaNineHundredAndNinetyNineThousandCommaSixHundredAndNineteen_IsValid()
        {
            Assert.That(this.np.ToLong("eighty five trillion, thirty two billion, six hundred and seventy four million, nine hundred and ninety nine thousand, six hundred and nineteen"), Is.EqualTo(85032674999619));
        }

        [Test]
        public void EightyFiveTrillionCommaThirtyTwoBillionCommaSixHundredAndSeventyFourMillionCommaNineHundredAndNinetyNineThousandCommaSixHundredAndNineteen_Extension_IsValid()
        {
            Assert.That("eighty five trillion, thirty two billion, six hundred and seventy four million, nine hundred and ninety nine thousand, six hundred and nineteen".ToLong(), Is.EqualTo(85032674999619));
        }

        [Test]
        public void EightQuadrillion_IsValid()
        {
            Assert.That(this.np.ToLong("Eight Quadrillion"), Is.EqualTo(8000000000000000));
        }

        [Test]
        public void EightQuadrillion_ShortScale_IsValid()
        {
            Assert.That("Eight Quadrillion".ToLong(Scale.Short), Is.EqualTo(8000000000000000));
        }

        [Test]
        public void EightThousandBillion_LongScale_IsValid()
        {
            Assert.That("Eight Thousand Billion".ToLong(Scale.Long), Is.EqualTo(8000000000000000));
        }

        [Test]
        public void EightMillionBillion_IsValid()
        {
            // "million billion" is the same as quadrillion
            Assert.That("eight million billion".ToLong(), Is.EqualTo(8000000000000000));
        }
    }
}
