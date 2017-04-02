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

        [OneTimeSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Short, new CultureInfo("fr-FR"));
        }

        [Test]
        public void MinusOne_IsNotValid()
        {
            Assert.Throws(Is.TypeOf<OverflowException>()
                  .And.Message.EqualTo("Value was either too large or too small for an unsigned byte."),
                  () => this.np.ToByte("moins une"));
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

        [Test]
        public void Five_Extension_ToInt16_IsValid()
        {
            Assert.That("cinq".ToInt16(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToInt32_IsValid()
        {
            Assert.That("cinq".ToInt32(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToInt64_IsValid()
        {
            Assert.That("cinq".ToInt64(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToUInt_IsValid()
        {
            Assert.That("cinq".ToUInt(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToUInt16_IsValid()
        {
            Assert.That("cinq".ToUInt16(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToUInt32_IsValid()
        {
            Assert.That("cinq".ToUInt32(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToUInt64_IsValid()
        {
            Assert.That("cinq".ToUInt64(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }

        [Test]
        public void Five_Extension_ToLong_IsValid()
        {
            Assert.That("cinq".ToLong(new CultureInfo("fr-FR")), Is.EqualTo(5));
        }
    }
}
