using System;
using System.Drawing;
using System.Drawing.Text;

namespace MechForge.Fonts
{
    public class FontFactory : IFontFactory
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private readonly PrivateFontCollection fonts = new PrivateFontCollection();

        public Font BattleTechFont(float size) => new Font(fonts.Families[0], size);

        public FontFactory()
        {
            LoadFonts();
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