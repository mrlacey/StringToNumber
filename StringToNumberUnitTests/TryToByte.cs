﻿//-----------------------------------------------------------------------
// <copyright file="TryToByte.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests
{
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class TryToByte
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

            var result = this.np.TryToByte("zero", out value);

            Assert.That(result, Is.EqualTo(true));
            Assert.That(value, Is.EqualTo(0));
        }
    }
}
