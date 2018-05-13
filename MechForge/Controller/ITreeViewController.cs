using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MechForge.Controller
{
    interface ITreeViewController
    {
        DirectoryInfo DirectoryInfo
        {
            set;
        }
        FastColoredTextBox Editor { set; }
        TreeNode SelectedNode { get; set; }

        void Clear();
        void Build();

    }
}
