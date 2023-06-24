using System;
using System.IO;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class FinderForm : Form
    {
        private DirectoryForm _parent;

        public FinderForm(DirectoryForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void FinderForm_Load(object sender, EventArgs e)
        {
            masksCheckedListBox.Items.AddRange(new string[] { "*.doc", "*.docx", "*.pdf, ", "*.txt", "*.cpp", "*.cs", "*.png", "*.jpg", "*.mp3", "*.PNG", "*.webp", "*.exe" });
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };

            if (folder.ShowDialog() == DialogResult.OK)
                folderPathTextBox.Text = folder.SelectedPath;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (folderPathTextBox.Text == string.Empty || folderPathTextBox.Text == null)
            {
                MessageBox.Show("Choose correct folder path!", "Warning");
                return;
            }

            if (masksCheckedListBox.CheckedItems.Count != 1)
            {
                MessageBox.Show("Choose only one mask!", "Warning");
                return;
            }

            var findPattern = (string)masksCheckedListBox.CheckedItems[0];

            if (Directory.Exists(folderPathTextBox.Text))
                _parent.InformDirectoryListBox(folderPathTextBox.Text, findPattern);
        }

        private void addNewMaskButton_Click(object sender, EventArgs e)
        {
            var addMask = new AddMaskForm();
            if (addMask.ShowDialog() != DialogResult.Cancel)
                masksCheckedListBox.Items.Add(addMask.Mask);
        }
    }
}