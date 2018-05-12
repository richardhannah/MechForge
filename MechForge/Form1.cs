using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using MechForge.Controller;
using MechForge.Fonts;
using MechForge.Translator;

namespace MechForge
{
    public partial class Form1 : Form
    {
        private ITreeViewController treeViewController;
        private DataCategory currentCategory;
        private IFontFactory fontFactory;


        public Form1()
        {
            InitializeComponent();
            fontFactory = new FontFactory();
            InitializeFonts();

            string defaultDirectory = ConfigurationManager.AppSettings["defaultDataDir"];
            treeViewController = new TreeViewController(new DirectoryInfo(defaultDirectory),treeView1,new FilenameTranslator() );
            FolderTextBox.Text = defaultDirectory;
            treeViewController.Editor = fastColoredTextBox1;

            EditorTab.TabPages.Remove(DesignerTab);
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentCategory = ParseDataCategory(e);
            lblSelectedCategory.Text = currentCategory.ToString();

            if (currentCategory == DataCategory.weapon)
            {
                if (!EditorTab.TabPages.Contains(DesignerTab))
                {
                    EditorTab.TabPages.Add(DesignerTab);
                }
                
            }
            else
            {
                EditorTab.TabPages.Remove(DesignerTab);
            }
        }

        private DataCategory ParseDataCategory(TreeViewEventArgs e)
        {
            return e.Node.Parent.Text == "data" ? TextToEnum(e.Node.Text) : TextToEnum(e.Node.Parent.Text);
        }

        private DataCategory TextToEnum(string text)
        {
            try
            {
                return (DataCategory) Enum.Parse(typeof(DataCategory), text);
            }
            catch (ArgumentException ex)
            {
                return DataCategory.undefined;
            }
        }

        private void InitializeFonts()
        {
            lblHeading.Font = fontFactory.Heading1;
            btnSave.Font = fontFactory.ButtonFont;
            LoadButton.Font = fontFactory.ButtonFont;
            EditorTab.Font = fontFactory.ButtonFont;
            DesignerTab.Font = fontFactory.ButtonFont;
            lblDataFolder.Font = fontFactory.Heading2;
            lblResourceBrowser.Font = fontFactory.Heading2;
            lblSelectedCategory.Font = fontFactory.ButtonFont;
        }

    }
}
