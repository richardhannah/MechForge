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
using MechForge.Translator;

namespace MechForge
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        private Font headerFont;
        private Font bigLabelFont;
        private Font buttonFont;

        private ITreeViewController treeViewController;
        private DataCategory currentCategory;


        public Form1()
        {
            InitializeComponent();
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
            byte[] fontData = Properties.Resources.BTLogo_old;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.BTLogo_old.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.BTLogo_old.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            headerFont = new Font(fonts.Families[0], 20.0F);
            bigLabelFont = new Font(fonts.Families[0], 10.0F);
            buttonFont = new Font(fonts.Families[0], 8.0F);

            lblHeading.Font = headerFont;
            btnSave.Font = buttonFont;
            LoadButton.Font = buttonFont;
            EditorTab.Font = buttonFont;
            DesignerTab.Font = buttonFont;
            lblDataFolder.Font = bigLabelFont;
            lblResourceBrowser.Font = bigLabelFont;
            lblSelectedCategory.Font = buttonFont;
        }

    }
}
