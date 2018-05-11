using System;
using MechForge.Translator;
using MechForge.Translator.Header;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MechForgeTests.Translator
{
    [TestClass]
    public class FileNameTranslatorTests
    {
        [TestMethod]
        public void TestTranslatorReturnsValidType()
        {
            string testString = "weapon_someotherstuff";
            
            IFileNameTranslator testSubject = new FilenameTranslator();
            Type translatedType = testSubject.GetTypeFor(testString);

            Assert.AreEqual(typeof(WeaponHeader).FullName,translatedType.FullName);

        }

        [TestMethod]
        public void TestTranslatorReturnsDefaultHeader()
        {
            string testString = "x_someotherstuff";

            IFileNameTranslator testSubject = new FilenameTranslator();
            Type translatedType = testSubject.GetTypeFor(testString);

            Assert.AreEqual(typeof(DefaultHeader).FullName, translatedType.FullName);

        }
    }
}
