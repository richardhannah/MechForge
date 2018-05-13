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
        private const string ROOT_DIRECTORY_NAME = "data";

        private readonly ITreeViewController treeViewController;
        private readonly IFontFactory fontFactory;
        private readonly IFileSystemDAO fileSystemDao;
        private readonly IFileNameTranslator fileNameTranslator;

        private bool textChanged;
        private string originalText;

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

        private void onFileLoadedHandler(object sender, EventArgs e)
        {

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
            if (e.Node.Name.EndsWith("json"))
            {
                LoadFile(e.Node.Name);
            }

            string labelText = buildCategory(e.Node);
            lblSelectedCategory.Text = labelText.Substring(0,labelText.Length - 3);
            string category = labelText.Split('/')[0];
            if (category.TrimEnd(' ') == "weapon" && !EditorTab.TabPages.Contains(DesignerTab))
            {
                EditorTab.TabPages.Add(DesignerTab);
            }
        }

        private string buildCategory(TreeNode node, string labelText = "")
        {
            if (node.Text == ROOT_DIRECTORY_NAME)
            {
                return labelText;
            }
            
            labelText =$"{node.Text} / {labelText}";
            return buildCategory(node.Parent, labelText);
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
            Debug.WriteLine("TextChanged Event fired");
//            if (!fastColoredTextBox1.Text.Equals(originalText) || fastColoredTextBox1.Text != "")
//            {
//                textChanged = true;
//                TabPage codeTab = EditorTab.TabPages[EditorTab.TabPages.IndexOf(CodeTab)];
//                codeTab.Text = codeTab.Text + "*";
//            }
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Load event fired");
//            originalText = fastColoredTextBox1.Text;
        }

        private bool LoadFile(string filename)
        {
            string text = File.ReadAllText(filename);

            try
            {
                string formatted = JToken.Parse(text).ToString(Formatting.Indented);
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
