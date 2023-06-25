using System;
using System.IO;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class TextEditorForm : Form
    {
        private string fileName;

        public TextEditorForm()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Text File(*.txt)|*.txt";
        }

        private void TextEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    throw new OperationCanceledException("Save operation was canceled.");

                fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, richTextBox.Text);
                MessageBox.Show("Save successful");
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
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                fileName = openFileDialog.FileName;
                string fileText = File.ReadAllText(fileName);
                richTextBox.Text = fileText;
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

        private void PerformClipboardOperation(ClipboardOperation operation)
        {
            switch (operation)
            {
                case ClipboardOperation.Copy:
                    if (richTextBox.TextLength > 0)
                    {
                        richTextBox.Copy();
                    }
                    break;
                case ClipboardOperation.Paste:
                    richTextBox.Paste();
                    break;
                case ClipboardOperation.Cut:
                    if (richTextBox.TextLength > 0)
                    {
                        richTextBox.Cut();
                    }
                    break;
                case ClipboardOperation.SelectAll:
                    if (richTextBox.TextLength > 0)
                    {
                        richTextBox.SelectAll();
                    }
                    break;
                default:
                    break;
            }
        }

        enum ClipboardOperation
        {
            Copy,
            Paste,
            Cut,
            SelectAll
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.Copy);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.Paste);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.Cut);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.SelectAll);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richTextBox.Font = fontDialog.Font;
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTextBox.BackColor = colorDialog.Color;
        }

        private void richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                richTextBox.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.Copy);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.Paste);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.Cut);
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PerformClipboardOperation(ClipboardOperation.SelectAll);
        }

        private void developerMode_Click(object sender, EventArgs e)
        {
            DevModeForm devMode = new DevModeForm();
            devMode.Show();
        }
    }
}
