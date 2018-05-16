using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MechForge.ModTek
{
    public class ModTekManager
    {
        public bool ModTechInstalled
        {
            get
            {
                DirectoryInfo battleTechDirInfo = new DirectoryInfo(ConfigurationManager.AppSettings["battleTechDir"]);

                if (!battleTechDirInfo.GetDirectories().Any(dir => dir.Name.Equals("Mods")))
                {
                    return false;
                }

                DirectoryInfo modsDir = battleTechDirInfo.GetDirectories().First(dir => dir.Name.Equals("Mods"));

                if (!modsDir.GetFiles().Any(file => file.Name.Equals("ModTek.dll")))
                {
                    return false;
                }

                return true;
            }
        }

        public void Initialize()
        {
            //TODO enumerate directories and populate list for form
            //Debug.WriteLine("initializing ModTek");
        }
    }
}