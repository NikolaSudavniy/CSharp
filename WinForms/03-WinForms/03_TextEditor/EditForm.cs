using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        public string DataText
        {
            get => editTextBox.Text;
            private set => editTextBox.Text = value;
        }

        public EditForm(string s)
        {
            InitializeComponent();
            DataText = s;
            editTextBox.ReadOnly = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.InitialDirectory = "c:\\";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
                        writer.Write(editTextBox.Text);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
