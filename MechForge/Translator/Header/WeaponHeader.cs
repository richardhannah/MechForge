namespace MechForge.Translator.Header
{
    public class WeaponHeader : BaseHeader
    {
        public WeaponHeader(string[] headerData) : base(headerData) { }

        public override string Filename { get; set; }
    }
}