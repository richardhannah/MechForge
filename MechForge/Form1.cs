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
        private string currentlyLoadedFile;
        private List<string> exclusionList;

        public Form1()
        {
            InitializeComponent();
            string defaultDirectory = ConfigurationManager.AppSettings["defaultDataDir"];
            FolderTextBox.Text = defaultDirectory;

            exclusionList = new List<string>();
            exclusionList.Add(".gitignore");
            exclusionList.Add("git");

            LoadDirectory(defaultDirectory);
            
            
        }

        private void LoadDirectory(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            if (directoryInfo.Exists)
            {
                treeView1.AfterSelect += treeView1_AfterSelect;
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadDirectory(FolderTextBox.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textToSave = fastColoredTextBox1.Text;
            File.WriteAllText(currentlyLoadedFile, textToSave);
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection treeNodes)
        {
            //treeNodes.Clear();

            TreeNode currentNode = treeNodes.Add(directoryInfo.Name);            

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                
                    currentNode.Nodes.Add(file.FullName, file.Name);
                
                
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                
                    BuildTree(subdir, currentNode.Nodes);
                               
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("json"))
            {
                if (LoadFile(e.Node.Name))
                {
                    currentlyLoadedFile = e.Node.Name;
                }
            }
        }

        private bool LoadFile(string filename)
        {
            string text = File.ReadAllText(filename);

            try
            {
                string formatted = JValue.Parse(text).ToString(Newtonsoft.Json.Formatting.Indented);
                fastColoredTextBox1.Text = formatted;
            }
            catch (JsonReaderException exception)
            {
                return false;
            }

            return true;
        }
    }
}
