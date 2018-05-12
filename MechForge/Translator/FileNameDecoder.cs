using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MechForge.Translator.Header;

namespace MechForge.Translator
{
    public class FileNameDecoder : IFilenameDecoder
    {
        
        public string[] HeaderData { get; }

        private Dictionary<string, Type> typeLookup = new Dictionary<string, Type>()
        {
            { "weapon", typeof(WeaponHeader)},
            { "Ability", typeof(AbilityHeader) }
        };

        public DecodedFileName DecodeFilename(string filename)
        {

            DecodedFileName decoded = new DecodedFileName();
            decoded.Filename = filename;

            string[] headerData;

         

            headerData = filename.Split('_');

            if (headerData.Length == 1)
            {
                headerData = splitCamelCaseStrings(filename);
            }

            string key = headerData[0];

            if (typeLookup.ContainsKey(key))
            {
                decoded.HeaderType = typeLookup[key];
            }
            else
            {
                decoded.HeaderType = typeof(DefaultHeader);
            }

            decoded.HeaderData = headerData;

            return decoded;
        }

        private string[] splitCamelCaseStrings(string filename)
        {
            return Regex.Split(filename, @"(?<!^)(?=[A-Z])");
        }

    }
}