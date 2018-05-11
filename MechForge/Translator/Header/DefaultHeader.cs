namespace MechForge.Translator.Header
{
    public class DefaultHeader : BaseHeader
    {

        public DefaultHeader(string [] headerData) : base(headerData) { }

        public override string Filename { get; set; }
    }
}