using System;
using System.Drawing;
using System.Drawing.Text;

namespace MechForge.Fonts
{
    public class FontFactory : IFontFactory
    {
        private Font buttonFont;
        private Font heading1;
        private Font heading2;

        public Font ButtonFont
        {
            get { return buttonFont; }
        }
        public Font Heading1
        {
            get { return heading1; }
        }
        public Font Heading2
        {
            get { return heading2; }
        }

        public Font getFont(float size)
        {
            return new Font(fonts.Families[0],size);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        public FontFactory()
        {
            LoadFonts();

            heading1 = new Font(fonts.Families[0], 20.0F);
            heading2 = new Font(fonts.Families[0], 10.0F);
            buttonFont = new Font(fonts.Families[0], 8.0F);
        }

        private void LoadFonts()
        {
            byte[] fontData = Properties.Resources.BTLogo_old;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.BTLogo_old.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.BTLogo_old.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }

    }
}