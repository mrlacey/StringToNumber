//-----------------------------------------------------------------------
// <copyright file="ToInt64LongScale.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests
{
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class ToInt64LongScale
    {
        private NumberParser np;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Long);
        }

        [Test]
        public void SixBillion_IsValid()
        {
            Assert.That(this.np.ToInt64("six billion"), Is.EqualTo(6000000000000));
        }

        [Test]
        public void SixBillion_Extension_IsValid()
        {
            Assert.That("six billion".ToInt64(Scale.Long), Is.EqualTo(6000000000000));
        }
    }
}
