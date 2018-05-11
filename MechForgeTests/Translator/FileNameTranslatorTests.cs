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
            var translatedType = testSubject.Decode(testString);

            Assert.AreEqual(typeof(WeaponHeader),translatedType.GetType());

        }

        [TestMethod]
        public void TestTranslatorReturnsDefaultHeader()
        {
            string testString = "x_someotherstuff";

            IFileNameTranslator testSubject = new FilenameTranslator();
            var translatedType = testSubject.Decode(testString);

            Assert.AreEqual(typeof(DefaultHeader), translatedType.GetType());

        }
    }
}
