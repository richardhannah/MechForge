using System.Drawing;

namespace MechForge.Fonts
{
    public interface IFontFactory
    {

        Font ButtonFont { get; }
        Font Heading1 { get; }
        Font Heading2 { get; }

        Font getFont(float size);

    }
}