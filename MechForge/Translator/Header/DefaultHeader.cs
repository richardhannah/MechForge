namespace MechForge.Translator.Header
{
    public class DefaultHeader : BaseHeader
    {

        public DefaultHeader(string [] headerData) : base(headerData) { }

        public override string ItemId
        {
            get
            {
                string itemId = "";
                for (int i = 1; i < headerData.Length; i++)
                {
                    if (i == headerData.Length -1)
                    {
                        itemId += headerData[i].Split('.')[0];
                    }
                    else
                    {
                        itemId += headerData[i];
                    }
                }

                return itemId.Length > 0 ? itemId : "ItemId not found";
            }
        }

        public override string Filename { get; set; }
    }
}