using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using MechForge.Controller;
using MechForge.Translator;

namespace MechForge
{
    public partial class Form1 : Form
    {
        private string currentlyLoadedFile;
        private List<string> exclusionList;

        private ITreeViewController treeViewController;

        public Form1()
        {
            InitializeComponent();
            string defaultDirectory = ConfigurationManager.AppSettings["defaultDataDir"];
            treeViewController = new TreeViewController(new DirectoryInfo(defaultDirectory),treeView1,new FilenameTranslator() );
            FolderTextBox.Text = defaultDirectory;
            treeViewController.Editor = fastColoredTextBox1;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            treeViewController.Clear();
            treeViewController.DirectoryInfo = new DirectoryInfo(FolderTextBox.Text);
            treeViewController.Build();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textToSave = fastColoredTextBox1.Text;
            File.WriteAllText(treeViewController.SelectedNode.Name, textToSave);
        }

        
    }
}
