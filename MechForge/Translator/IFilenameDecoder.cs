using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechForge.Translator
{
    public interface IFilenameDecoder
    {
        DecodedFileName DecodeFilename(string filename);
    }
}
