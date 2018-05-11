using System.Threading;

namespace MechForge.Translator.Header
{
    public abstract class BaseHeader
    {
        protected string[] headerData;

        public abstract string Filename { get; set; }

        public virtual string ItemId
        {
            get
            {
                if (headerData.Length > 1)
                {
                    return headerData[1];
                }

                return "item id not found";
            }
        }

        public BaseHeader(string[] headerData)
        {
            this.headerData = headerData;
        }
    }
}