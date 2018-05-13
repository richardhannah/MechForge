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
using MechForge.Data;
using MechForge.Fonts;
using MechForge.Translator;

namespace MechForge
{
    public partial class Form1 : Form
    {
        private readonly ITreeViewController treeViewController;
        private readonly IFontFactory fontFactory;
        private readonly IFileSystemDAO fileSystemDao;
        private readonly IFileNameTranslator fileNameTranslator;

        private DataCategory currentCategory;
        private bool textChanged;

        public Form1()
        {
            InitializeComponent();

            fontFactory = new FontFactory();
            fileSystemDao = new FileSystemDAO();
            fileNameTranslator = new FilenameTranslator();
            treeViewController = new TreeViewController(fileSystemDao.DefaultDirectoryInfo, treeView1, fileNameTranslator);

            InitializeFonts();

            FolderTextBox.Text = fileSystemDao.DefaultDirectoryInfo.FullName;
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
            try
            {
                File.WriteAllText(treeViewController.SelectedNode.Name, textToSave);
            }
            catch (NullReferenceException ex)
            {
                //swallow for now
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (textChanged)
            {
                //MessageBox.Show("text changed");

            }

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
            try
            {
                return e.Node.Parent.Text == "data" ? TextToEnum(e.Node.Text) : TextToEnum(e.Node.Parent.Text);
            }
            catch (NullReferenceException ex)
            {
                return DataCategory.undefined;
            }
            
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
            lblHeading.Font = fontFactory.BattleTechFont(20F);
            LoadButton.Font = fontFactory.BattleTechFont(8F);
            EditorTab.Font = fontFactory.BattleTechFont(8F);
            DesignerTab.Font = fontFactory.BattleTechFont(8F);
            lblDataFolder.Font = fontFactory.BattleTechFont(10F);
            lblResourceBrowser.Font = fontFactory.BattleTechFont(10F);
            lblSelectedCategory.Font = fontFactory.BattleTechFont(8F);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            textChanged = true;
        }
    }
}
