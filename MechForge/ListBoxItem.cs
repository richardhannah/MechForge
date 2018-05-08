using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechForge
{
    class ListBoxItem
    {

        private string filename;

        public string Filename { get; }

        public ListBoxItem(string filename)
        {
            this.filename = filename;
        }

    }
}
