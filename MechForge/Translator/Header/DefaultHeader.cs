using System;

namespace MechForge.Translator.Header
{
    public class DefaultHeader : BaseHeader
    {

        public DefaultHeader(DecodedFileName decodedFileName) : base(decodedFileName) { }

        public override string ItemId
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

        
    }
}