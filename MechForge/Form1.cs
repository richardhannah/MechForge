using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechForge
{
    public partial class Form1 : Form
    {
        private string directory;


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string path = FolderTextBox.Text;
            directory = "D:\\SteamLibrary\\steamapps\\common\\BATTLETECH\\BattleTech_Data\\StreamingAssets\\data\\mech";

            Debug.WriteLine(directory);
            DirectoryInfo di = new DirectoryInfo(directory);

            List<FileInfo> filenames = new List<FileInfo>();

            try
            {
                filenames = di.GetFiles().ToList<FileInfo>();
            }
            catch (DirectoryNotFoundException ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

            FileListBox.DataSource = filenames;
            FileListBox.DisplayMember = "Name";
            

        }

        private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filename = FileListBox.Text;

            

            string text = File.ReadAllText($"{directory}\\{filename}");

            string formatted = JValue.Parse(text).ToString(Newtonsoft.Json.Formatting.Indented);

            editorTextBox.Text = formatted;
        }
    }
}
