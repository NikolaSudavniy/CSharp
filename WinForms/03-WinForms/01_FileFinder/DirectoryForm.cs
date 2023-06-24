using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class DirectoryForm : Form
    {
        private string _findPattern;

        public DirectoryForm()
        {
            InitializeComponent();
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists($"{ directoryListBox.SelectedItem.ToString()}\\{filesListBox.SelectedItem.ToString()}"))
            {
                MessageBox.Show("Does something with this file");
            }
            else if (Directory.Exists(filesListBox.SelectedItem.ToString()))
            {
                AddDirectories(filesListBox.SelectedItem.ToString());
                filesListBox.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nothing is here");
            }
        }

        private void AddDirectories(string directoryPath)
        {
            directoryListBox.Items.Clear();

            // Add current directory
            directoryListBox.Items.Add(Path.GetFullPath(directoryPath));

            // Gets all directories in "directoryPath", converts them to List and adds each directory in "directoryListBox"
            Directory.GetDirectories(directoryPath).ToList().ForEach(
                f => directoryListBox.Items.Add(Path.GetFullPath(f)));
        }

        private void AddFilesAndSubDirectories(string directoryPath, string findPattern)
        {
            filesListBox.Items.Clear();

            // Gets all files in directory path, converts them to List and adds each file in "filesListBox"
            Directory.GetFiles(directoryPath, findPattern).ToList().ForEach(
            f => filesListBox.Items.Add(Path.GetFileName(f)));

            Directory.GetDirectories(directoryPath).ToList().ForEach(
                f => filesListBox.Items.Add(Path.GetFullPath(f)));
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var find = new FinderForm(this);
            find.Show();
        }

        public void InformDirectoryListBox(string directoryPath, string findPattern)
        {
            _findPattern = findPattern;

            AddDirectories(directoryPath);
            AddFilesAndSubDirectories(directoryPath, _findPattern);
        }

        private void directoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddFilesAndSubDirectories(directoryListBox.SelectedItem.ToString(), _findPattern);
        }
    }
}