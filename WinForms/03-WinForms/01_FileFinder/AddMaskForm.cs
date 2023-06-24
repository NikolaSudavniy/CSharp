using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class AddMaskForm : Form
    {
        public string Mask { get; set; }

        public AddMaskForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(fileMaskTextBox.Text, ".*"))
            {
                Mask = fileMaskTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                fileMaskTextBox.Clear();
                MessageBox.Show("Wrong!", "Warning");
            }
        }
    }
}