using System;
using System.Threading;

namespace MechForge.Translator.Header
{
    public abstract class BaseHeader
    {

        protected DecodedFileName decodedFileName;

        public virtual string Filename
        {
            get
            {
                return decodedFileName.Filename;
            }
        }

        public virtual string DisplayName
        {
            get
            {
                string itemId = "";
                try
                {
                    for (int i = 1; i < decodedFileName.HeaderData.Length; i++)
                    {
                        if (i == decodedFileName.HeaderData.Length - 1)
                        {
                            itemId += decodedFileName.HeaderData[i].Split('.')[0];
                        }
                        else
                        {
                            itemId += decodedFileName.HeaderData[i];
                        }
                    }
                }
                catch (NullReferenceException exception)
                {
                    return decodedFileName.Filename;
                }

                return itemId.Length > 0 ? itemId : decodedFileName.Filename;
            }

        }

        public BaseHeader(DecodedFileName decodedFileName)
        {
            this.decodedFileName = decodedFileName;
        }
    }
}