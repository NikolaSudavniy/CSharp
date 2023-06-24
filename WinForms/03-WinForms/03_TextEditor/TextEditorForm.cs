using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
        }

        private OpenFileDialog openFileDialog;

        private void TextEditorForm_Load(object sender, EventArgs e)
        {
        }

        private void TextEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.InitialDirectory = "c:\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                        readOnlyFromFileTextBox.Text = reader.ReadToEnd();

                    editButton.Enabled = true;
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(readOnlyFromFileTextBox.Text);

            if (editForm.ShowDialog() == DialogResult.OK)
                readOnlyFromFileTextBox.Text = editForm.DataText;
        }
    }
}
