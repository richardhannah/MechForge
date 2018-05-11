using System;

namespace MechForge.Translator
{
    public interface IFileNameTranslator
    {
        Type GetTypeFor(string filename);
        string Encode<T>(object header);
        T Decode<T>(string filename);
    }
}