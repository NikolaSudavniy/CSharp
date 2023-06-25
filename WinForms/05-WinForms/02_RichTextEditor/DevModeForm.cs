using System;
using System.IO;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class DevModeForm : Form
    {
        private string fileName;
        public DevModeForm()
        {
            InitializeComponent();
            switch (comboBoxDev.Text)
            {
                case "HTML":
                    saveFileDialogDev.Filter = "Web page (*.html)|*.html";
                    break;
                case "CSS":
                    saveFileDialogDev.Filter = "Styles file (*.css)|*.css";
                    break;
                case "JavaScript":
                    saveFileDialogDev.Filter = "Script file (*.js)|*.js";
                    break;
                default:
                    break;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialogDev.ShowDialog() == DialogResult.Cancel)
                    throw new OperationCanceledException("Save operation was canceled.");

                fileName = saveFileDialogDev.FileName;
                File.WriteAllText(fileName, richTextBoxDev.Text);
                MessageBox.Show("Save successful");
                File.WriteAllText("site.t$", fileName);
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the file: " + ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogDev.ShowDialog() == DialogResult.Cancel)
                    return;

                fileName = openFileDialogDev.FileName;
                string fileText = File.ReadAllText(fileName);
                richTextBoxDev.Text = fileText;
                File.WriteAllText("path.t$", fileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while loading the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialogDev.ShowDialog();
            richTextBoxDev.Font = fontDialogDev.Font;
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialogDev.ShowDialog();
            richTextBoxDev.BackColor = colorDialogDev.Color;
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Web site = new Web();
            site.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText("path.t$");
            File.WriteAllText(path, richTextBoxDev.Text);
        }
    }
}
