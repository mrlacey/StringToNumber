//-----------------------------------------------------------------------
// <copyright file="SanityCheck.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests
{
    using System;
    using System.Globalization;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class SanityCheck
    {
        private NumberParser np;
        private byte byteValue;
        private sbyte sbyteValue;
        private short shortValue;
        private ushort ushortValue;
        private Int16 int16Value;
        private UInt16 uint16Value;
        private int intValue;
        private uint uintValue;
        private Int32 int32Value;
        private UInt32 uint32Value;
        private long longValue;
        private ulong ulongValue;
        private Int64 int64Value;
        private UInt64 uint64Value;

        [TestFixtureSetUp]
        public void SetUp()
        {
            this.np = new NumberParser(Scale.Short);
        }

        [Test]
        public void AllToMethods_AreValid()
        {
            Assert.That(this.np.ToByte("one"), Is.EqualTo(1));
            Assert.That(this.np.ToSByte("one"), Is.EqualTo(1));
            Assert.That(this.np.ToShort("one"), Is.EqualTo(1));
            Assert.That(this.np.ToUShort("one"), Is.EqualTo(1));
            Assert.That(this.np.ToInt16("one"), Is.EqualTo(1));
            Assert.That(this.np.ToUInt16("one"), Is.EqualTo(1));
            Assert.That(this.np.ToInt("one"), Is.EqualTo(1));
            Assert.That(this.np.ToUInt("one"), Is.EqualTo(1));
            Assert.That(this.np.ToInt32("one"), Is.EqualTo(1));
            Assert.That(this.np.ToUInt32("one"), Is.EqualTo(1));
            Assert.That(this.np.ToLong("one"), Is.EqualTo(1));
            Assert.That(this.np.ToULong("one"), Is.EqualTo(1));
            Assert.That(this.np.ToInt64("one"), Is.EqualTo(1));
            Assert.That(this.np.ToUInt64("one"), Is.EqualTo(1));
        }

        [Test]
        public void AllTryToMethods_AreValid()
        {
            Assert.That(this.np.TryToByte("one", out byteValue), Is.EqualTo(true));
            Assert.That(byteValue, Is.EqualTo(1));

            Assert.That(this.np.TryToSByte("one", out sbyteValue), Is.EqualTo(true));
            Assert.That(sbyteValue, Is.EqualTo(1));

            Assert.That(this.np.TryToShort("one", out shortValue), Is.EqualTo(true));
            Assert.That(shortValue, Is.EqualTo(1));

            Assert.That(this.np.TryToUShort("one", out ushortValue), Is.EqualTo(true));
            Assert.That(ushortValue, Is.EqualTo(1));

            Assert.That(this.np.TryToInt16("one", out int16Value), Is.EqualTo(true));
            Assert.That(int16Value, Is.EqualTo(1));

            Assert.That(this.np.TryToUInt16("one", out uint16Value), Is.EqualTo(true));
            Assert.That(uint16Value, Is.EqualTo(1));

            Assert.That(this.np.TryToInt("one", out intValue), Is.EqualTo(true));
            Assert.That(intValue, Is.EqualTo(1));

            Assert.That(this.np.TryToUInt("one", out uintValue), Is.EqualTo(true));
            Assert.That(uintValue, Is.EqualTo(1));

            Assert.That(this.np.TryToInt32("one", out int32Value), Is.EqualTo(true));
            Assert.That(int32Value, Is.EqualTo(1));

            Assert.That(this.np.TryToUInt32("one", out uint32Value), Is.EqualTo(true));
            Assert.That(uint32Value, Is.EqualTo(1));

            Assert.That(this.np.TryToLong("one", out longValue), Is.EqualTo(true));
            Assert.That(longValue, Is.EqualTo(1));

            // Note. ulong is not yet fully supported
            //Assert.That(this.np.TryToULong("one", out ulongValue), Is.EqualTo(true));
            //Assert.That(ulongValue, Is.EqualTo(1));

            Assert.That(this.np.TryToInt64("one", out int64Value), Is.EqualTo(true));
            Assert.That(int64Value, Is.EqualTo(1));

            // Note. uint64 is not yet fully supported
            //Assert.That(this.np.TryToUInt64("one", out uint64Value), Is.EqualTo(true));
            //Assert.That(uint64Value, Is.EqualTo(1));
        }

        [Test]
        public void AllTryParseMethods_AreValid()
        {
            Assert.That(this.np.TryParse("one", out byteValue), Is.EqualTo(true));
            Assert.That(byteValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out sbyteValue), Is.EqualTo(true));
            Assert.That(sbyteValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out shortValue), Is.EqualTo(true));
            Assert.That(shortValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out ushortValue), Is.EqualTo(true));
            Assert.That(ushortValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out int16Value), Is.EqualTo(true));
            Assert.That(int16Value, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out uint16Value), Is.EqualTo(true));
            Assert.That(uint16Value, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out intValue), Is.EqualTo(true));
            Assert.That(intValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out uintValue), Is.EqualTo(true));
            Assert.That(uintValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out int32Value), Is.EqualTo(true));
            Assert.That(int32Value, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out uint32Value), Is.EqualTo(true));
            Assert.That(uint32Value, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out longValue), Is.EqualTo(true));
            Assert.That(longValue, Is.EqualTo(1));

            // Note. ulong is not yet fully supported
            //Assert.That(this.np.TryParse("one", out ulongValue), Is.EqualTo(true));
            //Assert.That(ulongValue, Is.EqualTo(1));

            Assert.That(this.np.TryParse("one", out int64Value), Is.EqualTo(true));
            Assert.That(int64Value, Is.EqualTo(1));

            // Note. uint64 is not yet fully supported
            //Assert.That(this.np.TryParse("one", out uint64Value), Is.EqualTo(true));
            //Assert.That(uint64Value, Is.EqualTo(1));
        }

        [Test]
        public void AllExtensionMethods_AreValid()
        {
            Assert.That("one".ToByte(), Is.EqualTo(1));
            Assert.That("one".ToByte(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToSByte(), Is.EqualTo(1));
            Assert.That("one".ToSByte(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToShort(), Is.EqualTo(1));
            Assert.That("one".ToShort(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToUShort(), Is.EqualTo(1));
            Assert.That("one".ToUShort(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToInt16(), Is.EqualTo(1));
            Assert.That("one".ToInt16(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToUInt16(), Is.EqualTo(1));
            Assert.That("one".ToUInt16(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToInt(), Is.EqualTo(1));
            Assert.That("one".ToInt(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToUInt(), Is.EqualTo(1));
            Assert.That("one".ToUInt(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToInt32(), Is.EqualTo(1));
            Assert.That("one".ToInt32(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToUInt32(), Is.EqualTo(1));
            Assert.That("one".ToUInt32(new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToLong(), Is.EqualTo(1));
            Assert.That("one".ToLong(new CultureInfo("en-GB")), Is.EqualTo(1));
            Assert.That("one".ToLong(Scale.Short), Is.EqualTo(1));
            Assert.That("one".ToLong(Scale.Short, new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToULong(), Is.EqualTo(1));
            Assert.That("one".ToULong(new CultureInfo("en-GB")), Is.EqualTo(1));
            Assert.That("one".ToULong(Scale.Short), Is.EqualTo(1));
            Assert.That("one".ToULong(Scale.Short, new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToInt64(), Is.EqualTo(1));
            Assert.That("one".ToInt64(new CultureInfo("en-GB")), Is.EqualTo(1));
            Assert.That("one".ToInt64(Scale.Short), Is.EqualTo(1));
            Assert.That("one".ToInt64(Scale.Short, new CultureInfo("en-GB")), Is.EqualTo(1));

            Assert.That("one".ToUInt64(), Is.EqualTo(1));
            Assert.That("one".ToUInt64(new CultureInfo("en-GB")), Is.EqualTo(1));
            Assert.That("one".ToUInt64(Scale.Short), Is.EqualTo(1));
            Assert.That("one".ToUInt64(Scale.Short, new CultureInfo("en-GB")), Is.EqualTo(1));
        }
    }
}
