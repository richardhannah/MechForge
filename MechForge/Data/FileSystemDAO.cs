using System.Configuration;
using System.IO;

namespace MechForge.Data
{
    public class FileSystemDAO : IFileSystemDAO
    {
        public DirectoryInfo DefaultDirectoryInfo => new DirectoryInfo(ConfigurationManager.AppSettings["defaultDataDir"]);

        public DirectoryInfo getDirectoryInfoForFileName(string filename)
        {
           return new DirectoryInfo(filename);
        }
    }
}