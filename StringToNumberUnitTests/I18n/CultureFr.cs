//-----------------------------------------------------------------------
// <copyright file="CultureFr.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests.I18n
{
    using System;
    using System.Globalization;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class CultureFr
    {
        private NumberParser np;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Short, new CultureInfo("fr-FR"));
        }

        [Test, ExpectedException(typeof(OverflowException), ExpectedMessage = "Value was either too large or too small for an unsigned byte.")]
        public void MinusOne_IsNotValid()
        {
            Assert.That(this.np.ToByte("moins une"), Is.EqualTo(-1));
        }

        [Test]
        public void Zero_IsValid()
        {
            Assert.That(this.np.ToByte("zero"), Is.EqualTo(0));
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            Assert.That("cinq".ToByte(new CultureInfo("fr-FR")), Is.EqualTo((byte)5));
        }

        [Test]
        public void Five_Extension_ToSByte_IsValid()
        {
            Assert.That("cinq".ToSByte(new CultureInfo("fr-FR")), Is.EqualTo((sbyte)5));
        }

        [Test]
        public void Five_Extension_ToShort_IsValid()
        {
            Assert.That("cinq".ToShort(new CultureInfo("fr-FR")), Is.EqualTo((short)5));
        }

        [Test]
        public void Five_Extension_ToUShort_IsValid()
        {
            Assert.That("cinq".ToUShort(new CultureInfo("fr-FR")), Is.EqualTo((ushort)5));
        }

        [Test]
        public void Five_Extension_ToInt_IsValid()
        {
            Assert.That("cinq".ToInt(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }
    }
}
