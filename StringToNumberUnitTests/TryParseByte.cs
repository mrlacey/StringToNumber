//-----------------------------------------------------------------------
// <copyright file="TryParseByte.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests
{
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class TryParseByte
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Short);
        }

        [Test]
        public void Zero_IsValid()
        {
            byte value;

            var result = this.np.TryParse("zero", out value);

            Assert.That(result, Is.EqualTo(true));
            Assert.That(value, Is.EqualTo(0));
        }

        [Test]
        public void ZeroFive_IsInvalid()
        {
            byte value;

            var result = this.np.TryParse("zero five", out value);

            Assert.That(result, Is.EqualTo(false));
            Assert.That(value, Is.EqualTo(default(byte)));
        }
    }
}
