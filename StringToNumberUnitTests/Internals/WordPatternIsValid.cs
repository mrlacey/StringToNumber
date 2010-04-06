//-----------------------------------------------------------------------
// <copyright file="WordPatternIsValid.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumberUnitTests.Internals
{
    using System.Text.RegularExpressions;
    using NUnit.Framework;
    using StringToNumber;

    [TestFixture]
    public class WordPatternIsValid
    {
        [Test]
        public void A_IsNotValidOnItsOwn()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("A", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void AA_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("AA", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void G_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("G", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void GAT_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("GAT", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void M_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("M", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void MM_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("MM", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void MT_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("MT", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void MU_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("MU", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void MUG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("MUG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void MUGMUGUGAMUGUGAMUGUGAT_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("MUGMUGUGAMUGUGAMUGUGAT", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void N_IsNotValidOnItsOwn()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("N", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void NA_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("NA", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void P_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("P", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void PP_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("PP", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void S_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("S", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void SG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("SG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void T_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("T", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void TA_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("TA", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void TU_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("TU", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void TM_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("TM", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void TAU_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("TAU", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void TT_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("TT", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void TG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("TG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void U_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("U", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UA_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UA", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void UAU_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UAU", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void UGU_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGU", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGM_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGM", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGT_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGT", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGAU_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGAU", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGAM_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGAM", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGAT_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGAT", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGAUG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGAUG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UGAMUG_IsValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UGAMUG", out matches);

            Assert.That(res, Is.True);
        }

        [Test]
        public void UT_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UT", out matches);

            Assert.That(res, Is.False);
        }

        [Test]
        public void UU_IsNotValid()
        {
            MatchCollection matches;

            var res = new NumberParser().WordPatternIsValid("UU", out matches);

            Assert.That(res, Is.False);
        }
    }
}
