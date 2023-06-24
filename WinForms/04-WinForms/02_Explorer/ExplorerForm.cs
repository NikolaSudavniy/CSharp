using System;
using System.IO;
using System.Windows.Forms;

namespace Explorer
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void ExitToolStripLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void RefreshTreeView(string startFolder)
        {
            FoldersTreeView.Nodes.Clear();
            FoldersTreeView.Nodes.Add(new TreeNode(startFolder));
            FillTreeView(FoldersTreeView.Nodes, Directory.GetDirectories(startFolder));
        }

        private void FillTreeView(TreeNodeCollection nodes, string[] folders)
        {
            try
            {
                foreach (TreeNode node in nodes)
                {
                    foreach (string folder in folders)
                    {
                        node.Nodes.Add(new TreeNode(folder));

                        FillTreeView(node.Nodes, Directory.GetDirectories(folder));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void showAllInsideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInside();
        }

        private void ShowInsideToolStripLabel_Click(object sender, EventArgs e)
        {
            ShowInside();
        }

        private void showInsideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInside();
        }

        private void ShowInside()
        {
            FoldersAndFilesBox.Items.Clear();
            DirSearch(FoldersTreeView.SelectedNode.Text);
            AddressTextBox.Text = FoldersTreeView.SelectedNode.Text;
        }

        private void DirSearch(string folderPath)
        {
            try
            {
                foreach (var d in Directory.GetDirectories(folderPath))
                    FoldersAndFilesBox.Items.Add(d);

                foreach (var d in Directory.GetFiles(folderPath))
                    FoldersAndFilesBox.Items.Add(d);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void setStartFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStartFolder();
        }

        private void SetstartfolderToolStripLabel_Click(object sender, EventArgs e)
        {
            SetStartFolder();
        }

        private void setStartFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetStartFolder();
        }

        private void SetStartFolder()
        {
            var open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
                RefreshTreeView(open.SelectedPath);
        }
    }
}