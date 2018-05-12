using System;
using System.Collections.Generic;
using MechForge.Translator;
using MechForge.Translator.Header;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MechForgeTests.Translator
{
    [TestClass]
    public class FileNameDecoderTests
    {
        [TestMethod]
        public void TestDecoderReturnsValidData()
        {
            IFilenameDecoder testSubject = new FileNameDecoder();

            foreach (Expectation expectation in decoderDataProvider())
            {
                DecodedFileName decodedFileName = testSubject.DecodeFilename(expectation.TestFilename);
                Assert.AreEqual(expectation.HeaderType, decodedFileName.HeaderType);
                for (int i = 0; i < expectation.HeaderData.Length; i++)
                {
                    Assert.AreEqual(expectation.HeaderData[i], decodedFileName.HeaderData[i]);
                }
                Assert.AreEqual(expectation.Filename, decodedFileName.Filename);

            }
        }

        private List<Expectation> decoderDataProvider()
        {
            return new List<Expectation>()
            {
                {new Expectation("expectedfilename",typeof(DefaultHeader),new string[]{"expectedfilename"},"expectedfilename")},
                {new Expectation("Weapon_Autocannon_AC2_0-STOCK.json",typeof(WeaponHeader),new string[]{"Weapon","Autocannon","AC2","0-STOCK"},"Weapon_Autocannon_AC2_0-STOCK.json")}
            };
        }

        public class Expectation
        {
            public string TestFilename { get; set; }
            public Type HeaderType { get; set; }
            public string[] HeaderData { get; set; }
            public string Filename { get; set; }

            public Expectation(string testFilename, Type headerType, string[] headerData, string filename)
            {
                TestFilename = testFilename;
                HeaderType = headerType;
                HeaderData = headerData;
                Filename = filename;
            }
        }


    }
}