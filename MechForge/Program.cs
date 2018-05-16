using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechForge.ModTek;

namespace MechForge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ModTekManager modTekManager = new ModTekManager();
            if (modTekManager.ModTechInstalled)
            {
                modTekManager.Initialize();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(modTekManager));
        }
    }
}
