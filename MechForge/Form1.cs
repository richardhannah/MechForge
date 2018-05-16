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
using System.Reflection;
using MechForge.Controller;
using MechForge.Data;
using MechForge.Domain;
using MechForge.Fonts;
using MechForge.ModTek;
using MechForge.ModTek.Dialog;
using MechForge.Translator;
using MechForge.UserControls;

namespace MechForge
{
    public partial class Form1 : Form
    {
        private const string ROOT_DIRECTORY_NAME = "data";

        private readonly ITreeViewController treeViewController;
        private readonly IFontFactory fontFactory;
        private readonly IFileSystemDAO fileSystemDao;
        private readonly IFileNameTranslator fileNameTranslator;
        private readonly ModTekManager modTekManager;


        private bool fileModified = false;
        private string rootBattleTechDir;

        private readonly Dictionary<string, Type> designAbleResources = new Dictionary<string, Type>()
        {
            {"weapon", typeof(Weapon)},
            {"chassis",typeof(Chassis)} 
        };
        

        public Form1(ModTekManager modTekManager)
        {
            InitializeComponent();

            this.modTekManager = modTekManager;
            fontFactory = new FontFactory();
            fileSystemDao = new FileSystemDAO();
            fileNameTranslator = new FilenameTranslator();
            treeViewController = new TreeViewController(fileSystemDao.DefaultDirectoryInfo, treeView1, fileNameTranslator);

            InitializeFonts();
            rootBattleTechDir = fileSystemDao.DefaultDirectoryInfo.Parent.Parent.Parent.FullName;
            
            
            FolderTextBox.Text = fileSystemDao.DefaultDirectoryInfo.FullName;
            treeViewController.Editor = fastColoredTextBox1;
            EditorTab.TabPages.Remove(DesignerTab);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (var fileBrowserDialog = new FolderBrowserDialog())
            {
                fileBrowserDialog.SelectedPath = FolderTextBox.Text;
                DialogResult result = fileBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileBrowserDialog.SelectedPath))
                {
                    FolderTextBox.Text = fileBrowserDialog.SelectedPath;
                }
            }

            LoadData();
        }

        private void LoadData()
        {
            treeViewController.DirectoryInfo = fileSystemDao.getDirectoryInfoForFileName(FolderTextBox.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            if (e.Node.Name.EndsWith("json") || e.Node.Name.EndsWith("csv"))
            {
                fastColoredTextBox1.Text = LoadFile(e.Node.Name);
                fastColoredTextBox1.Text = LoadFile(e.Node.Name);
            }
            
            string category = SetCategoryLabel(e.Node).TrimEnd(' ');

            EditorTab.TabPages.Remove(DesignerTab);

            if (ConfigurationManager.AppSettings["enableDesignerView"] == "true")
            {

                if (designAbleResources.ContainsKey(category))
                {

                    DesignerTab = CreateDesignerTabPage(category);
                    EditorTab.TabPages.Add(DesignerTab);
                }
            }

        }

        private TabPage CreateDesignerTabPage(string category)
        {
            TabPage tabPage = new TabPage("Designer View");
            tabPage.Controls.Add(GetControlSet(category));
            tabPage.AutoScroll = true;
            return tabPage;
        }

        private UserControl GetControlSet(string category)
        {
            Type designerType = designAbleResources[category];
            Type genericType = typeof(DesignerControl<>);
            Type customListType = genericType.MakeGenericType(designerType);
            IDesignerControl designerControl = (IDesignerControl)Activator.CreateInstance(customListType);

            IDesignable designable = designerControl.ControlSet;
            designable.JsonData = fastColoredTextBox1.Text;
            
            return (UserControl)designable;
        }

        private string SetCategoryLabel(TreeNode node)
        {
            string labelText = BuildCategory(node);
            lblSelectedCategory.Text = labelText.Substring(0, labelText.Length - 3);
            return labelText.Split('/')[0];
        }

        private string BuildCategory(TreeNode node, string labelText = "")
        {
            if (node.Text == ROOT_DIRECTORY_NAME)
            {
                return labelText;
            }
            
            labelText =$"{node.Text} / {labelText}";
            return BuildCategory(node.Parent, labelText);
        }

        private void InitializeFonts()
        {
            lblHeading.Font = fontFactory.BattleTechFont(20F);
            LoadButton.Font = fontFactory.BattleTechFont(8F);
            EditorTab.Font = fontFactory.BattleTechFont(8F);
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
                return JToken.Parse(text).ToString(Formatting.Indented);
                
            }
            catch (JsonReaderException exception)
            {
                toolStripStatusLabel1.Text = "Json error detected";
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

        private void FolderTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.Enter) == Keys.Enter)
            {
                LoadData();
            }
        }

        private void modTekModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modTekManager.ModTechInstalled)
            {
                OpenModTekDialog();
            }
            else
            {
                MessageBox.Show("ModTek not installed");
            }
        }

        private void OpenModTekDialog()
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 500;
            prompt.Text = "New ModTek Mod";
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "New ModTek dialog" };
            
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            
            prompt.ShowDialog();
        }

    }
}
