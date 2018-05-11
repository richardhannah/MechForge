using System;
using MechForge.Translator.Header;

namespace MechForge.Translator
{
    public interface IFileNameTranslator
    {
        
        string Encode<T>(object header);
        BaseHeader Decode(string filename);
    }
}