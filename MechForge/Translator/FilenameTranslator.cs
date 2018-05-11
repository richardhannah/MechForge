using System;
using System.Collections.Generic;
using MechForge.Translator.Header;

namespace MechForge.Translator
{
    public class FilenameTranslator : IFileNameTranslator
    {
        private string[] headerData;
        Char delimiter = '_';

        public string Encode<T>(object header)
        {
            throw new System.NotImplementedException();
        }

        public BaseHeader Decode(string filename) { 
            return instantiateHeader(filename);
        }

        private BaseHeader instantiateHeader(string filename)
        {
            return (BaseHeader)Activator.CreateInstance(getTypeFor(filename),new object[]{ headerData });
        }

        private Type getTypeFor(string filename)
        {
            Dictionary<string, Type> typeLookup = new Dictionary<string, Type>()
            {
                { "weapon", typeof(WeaponHeader)}
            };

            headerData = filename.Split(delimiter);
            string key = headerData[0];

            if (typeLookup.ContainsKey(key))
            {
                return typeLookup[key];
            }

            return typeof(DefaultHeader);
        }
    }
}