using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace MechForge
{
    public partial class Form1 : Form
    {
        private string directory;
        private string filename;

        public Form1()
        {
            InitializeComponent();
            string defaultDirectory = ConfigurationManager.AppSettings["defaultDataDir"];
            FolderTextBox.Text = defaultDirectory;

            DirectoryInfo directoryInfo = new DirectoryInfo(defaultDirectory);
            if (directoryInfo.Exists)
            {
                treeView1.AfterSelect += treeView1_AfterSelect;
                BuildTree(directoryInfo, treeView1.Nodes);
            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            directory = FolderTextBox.Text;
            
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

            filename = FileListBox.Text;          

            string text = File.ReadAllText($"{directory}\\{filename}");

            try
            {
                string formatted = JValue.Parse(text).ToString(Newtonsoft.Json.Formatting.Indented);
                fastColoredTextBox1.Text = formatted;
            }
            catch (JsonReaderException exception)
            {
                //swallow for now
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textToSave = fastColoredTextBox1.Text;
            File.WriteAllText($"{directory}\\{filename}",textToSave);

        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("json"))
            {
                LoadFile(e.Node.Name);
            }
        }

        private void LoadFile(string filename)
        {
            string text = File.ReadAllText(filename);

            try
            {
                string formatted = JValue.Parse(text).ToString(Newtonsoft.Json.Formatting.Indented);
                fastColoredTextBox1.Text = formatted;
            }
            catch (JsonReaderException exception)
            {
                //swallow for now
            }
        }
    }
}
