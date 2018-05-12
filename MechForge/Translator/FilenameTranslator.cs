using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MechForge.Translator.Header;

namespace MechForge.Translator
{
    public class FilenameTranslator : IFileNameTranslator
    {
        private IFilenameDecoder filenameDecoder;

        public FilenameTranslator()
        {
            this.filenameDecoder = new FileNameDecoder();
        }


        public string Encode<T>(object header)
        {
            throw new System.NotImplementedException();
        }

        public BaseHeader Decode(string filename) { 
            return instantiateHeader(filenameDecoder.DecodeFilename(filename));
        }

        private BaseHeader instantiateHeader(DecodedFileName decodedFileName)
        {
            return (BaseHeader)Activator.CreateInstance(decodedFileName.HeaderType, decodedFileName);
        }

        
    }
}