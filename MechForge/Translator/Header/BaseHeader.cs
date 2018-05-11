using System.Threading;

namespace MechForge.Translator.Header
{
    public abstract class BaseHeader
    {
        private string[] headerData;

        public abstract string Filename { get; set; }

        public BaseHeader(string[] headerData)
        {
            this.headerData = headerData;
        }
    }
}