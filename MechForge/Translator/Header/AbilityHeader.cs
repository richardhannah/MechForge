namespace MechForge.Translator.Header
{
    public class AbilityHeader : BaseHeader
    {
        public AbilityHeader(DecodedFileName decodedFileName) : base(decodedFileName)
        {
        }

        public virtual string ItemId
        {
            get
            {
                if (decodedFileName.HeaderData.Length > 1)
                {
                    return decodedFileName.HeaderData[0] + decodedFileName.HeaderData[1] + decodedFileName.HeaderData[2];
                }

                return Filename;
            }
        }
        }






    }
