namespace MechForge.Translator.Header
{
    public class ConstantsHeader : BaseHeader
    {
        public ConstantsHeader(DecodedFileName decodedFileName) : base(decodedFileName)
        {
        }


        public override string DisplayName
        {
            get
            {
                string displayName = "";
                if (decodedFileName.HeaderData.Length > 1)
                {
                    for (int i = 0; i < decodedFileName.HeaderData.Length; i++)
                    {
                        if (decodedFileName.HeaderData[i] != "Constants")
                        {
                            displayName += decodedFileName.HeaderData[i];
                        }
                        
                    }

                    return displayName;
                }

                return Filename;
            }
        }

    }
}