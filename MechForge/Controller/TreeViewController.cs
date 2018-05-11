using FastColoredTextBoxNS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechForge.Translator;

namespace MechForge.Controller
{
    class TreeViewController : ITreeViewController
    {

        private DirectoryInfo directoryInfo;
        private TreeViewController treeViewModel;
        private FastColoredTextBox editor;
        private TreeView treeView;
        private TreeNode selectedNode;
        private IFileNameTranslator fileNameTranslator;

        public DirectoryInfo DirectoryInfo { set { directoryInfo = value; } }
        public TreeView TreeView { set { treeView = value; } }
        public FastColoredTextBox Editor { set { editor = value; } }
        public TreeNode SelectedNode
        {
            get { return selectedNode; }
        }


        public TreeViewController(DirectoryInfo directoryInfo,TreeView treeView,IFileNameTranslator fileNameTranslator)
        {
            this.directoryInfo = directoryInfo;
            this.treeView = treeView;
            this.fileNameTranslator = fileNameTranslator;

            if (directoryInfo.Exists)
            {
                treeView.AfterSelect += treeView1_AfterSelect;
                BuildTree(directoryInfo, treeView.Nodes);
            }
        }

        public void Build()
        {
            BuildTree(directoryInfo, treeView.Nodes);
        }

        public void Clear()
        {
            treeView.Nodes.Clear();
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection treeNodes)
        {           

            TreeNode currentNode = treeNodes.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                var header = fileNameTranslator.Decode(file.Name);
                if (header.ItemId != "ItemId not found")
                {
                    currentNode.Nodes.Add(file.FullName, header.ItemId);
                }
                
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
                    selectedNode = e.Node;
                }
            }
        }

        private bool LoadFile(string filename)
        {
            string text = File.ReadAllText(filename);

            try
            {
                string formatted = JToken.Parse(text).ToString(Formatting.Indented);
                editor.Text = formatted;
            }
            catch (JsonReaderException exception)
            {
                return false;
            }

            return true;
        }

    }
}
