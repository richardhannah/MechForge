using System;
using System.Collections.Generic;
using MechForge.Translator.Header;

namespace MechForge.Translator
{
    public class FilenameTranslator : IFileNameTranslator
    {
        public string Encode<T>(object header)
        {
            throw new System.NotImplementedException();
        }

        public Type GetTypeFor(string filename)
        {
            Dictionary<string,Type> typeLookup = new Dictionary<string, Type>()
            {
                { "weapon", typeof(WeaponHeader)}
            };

            Char delimiter = '_';
            string key = filename.Split(delimiter)[0];

            if (typeLookup.ContainsKey(key))
            {
                return typeLookup[key];
            }

            return typeof(DefaultHeader);

        }

        public T Decode<T>(string filename)
        {

            T decoded = default(T);

            

            return decoded;
        }
    }
}