using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MechForge.Translator.Header;

namespace MechForge.Translator
{
    public class FileNameDecoder : IFilenameDecoder
    {
        
        private Dictionary<string, Type> typeLookup = new Dictionary<string, Type>()
        {
            { "Weapon", typeof(WeaponHeader)},
            { "Ability", typeof(AbilityHeader)},
            { "Application", typeof(ConstantsHeader)},
            { "Audio", typeof(ConstantsHeader)},
            { "Combat", typeof(ConstantsHeader)},
            { "Map", typeof(ConstantsHeader)},
            { "Mech", typeof(ConstantsHeader)}

        };

        public DecodedFileName DecodeFilename(string filename)
        {

            DecodedFileName decoded = new DecodedFileName();
            decoded.Filename = filename;
            string strippedFilename = StripFileNameExtension(filename);

            string[] headerData;

            headerData = strippedFilename.Split('_');

            if (headerData.Length == 1)
            {
                headerData = splitCamelCaseStrings(strippedFilename);
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

        private string StripFileNameExtension(string lastDatum)
        {
            return Path.GetFileNameWithoutExtension(lastDatum);
        }

        private string[] splitCamelCaseStrings(string filename)
        {
            return Regex.Split(filename, @"(?<!^)(?=[A-Z])");
        }

    }
}