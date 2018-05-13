using System.IO;

namespace MechForge.Data
{
    public interface IFileSystemDAO
    {
        DirectoryInfo DefaultDirectoryInfo { get; }
    }
}