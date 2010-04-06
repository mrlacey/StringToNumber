//-----------------------------------------------------------------------
// <copyright file="CultureFrNoSetup.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests.I18n
{
    using System.Globalization;
    using System.Threading;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class CultureFrNoSetup
    {
        [Test]
        public void Five_IsValid()
        {
            CultureInfo french = new CultureInfo("fr-FR");
            CultureInfo original = Thread.CurrentThread.CurrentCulture;

            Thread.CurrentThread.CurrentCulture = french;

            NumberParser np = new NumberParser();

            Assert.That(np.ToByte("cinq"), Is.EqualTo((byte)5));

            Thread.CurrentThread.CurrentCulture = original;
        }

        [Test]
        public void Five_Extension_IsValid()
        {
            CultureInfo french = new CultureInfo("fr-FR");
            CultureInfo original = Thread.CurrentThread.CurrentCulture;

            Thread.CurrentThread.CurrentCulture = french;

            Assert.That("cinq".ToByte(), Is.EqualTo((byte)5));

            Thread.CurrentThread.CurrentCulture = original;
        }
    }
}
