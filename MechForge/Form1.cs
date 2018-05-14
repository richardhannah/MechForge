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
        private bool fileModified = false;

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
            treeViewController.DirectoryInfo = new DirectoryInfo(FolderTextBox.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("saving");
            string textToSave = fastColoredTextBox1.Text;
            try
            {
                File.WriteAllText(treeViewController.SelectedNode.Name, textToSave);
                fileModified = false;
                setEditorTabModified(false);
            }
            catch (NullReferenceException ex)
            {
                //swallow for now
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            setEditorTabModified(false);

            treeViewController.SelectedNode = e.Node;

            if (e.Node.Name.EndsWith("json")){
                fastColoredTextBox1.Text = LoadFile(e.Node.Name);
            }

            string labelText = buildCategory(e.Node);
            lblSelectedCategory.Text = labelText.Substring(0,labelText.Length - 3);
            string category = labelText.Split('/')[0];
            if (category.TrimEnd(' ') == "weapon" && !EditorTab.TabPages.Contains(DesignerTab))
            {
                EditorTab.TabPages.Add(DesignerTab);
            }
            else if(category.TrimEnd(' ') != "weapon")
            {
                EditorTab.TabPages.Remove(DesignerTab);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setEditorTabModified(bool modified)
        {
            TabPage codeTab = EditorTab.TabPages[EditorTab.TabPages.IndexOf(CodeTab)];
            if (modified) { 
                codeTab.Text = codeTab.Text + "*";
            }
            else
            {
                codeTab.Text = codeTab.Text.TrimEnd('*');
            }
        }

        

        private string LoadFile(string filename)
        {
            string text = File.ReadAllText(filename);

            try
            {
                string formatted = JToken.Parse(text).ToString(Formatting.Indented);
                
            }
            catch (JsonReaderException exception)
            {
                return "unable to format json";
            }

            return text;
        }

        private void fastColoredTextBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!fileModified)
            {
                setEditorTabModified(true);
                fileModified = true;
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");
        }
    }
}
