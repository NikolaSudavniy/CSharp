using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextFileEditor
{
    public partial class TextFileEditorForm : Form
    {
        private bool _newOpen = true;

        private Font CurFont
        {
            get => textForEditingTextBox.Font;
            set => textForEditingTextBox.Font = value;
        }

        private Color CurForeColor
        {
            get => textForEditingTextBox.ForeColor;
            set => textForEditingTextBox.ForeColor = value;
        }

        private Color CurBackColor
        {
            get => textForEditingTextBox.BackColor;
            set => textForEditingTextBox.BackColor = value;
        }

        public string TextFromBox
        {
            get => textForEditingTextBox.Text;
            set => textForEditingTextBox.Text = value;
        }

        public string SelectedText
        {
            get => textForEditingTextBox.SelectedText;
        }

        public string FormCaption
        {
            get => Text;
            set => Text = value;
        }

        public event EventHandler<MyEventArgs> ClickOnButton;

        public TextFileEditorForm()
        {
            InitializeComponent();
        }

        public void InfoMessageBox(string text, string caprion)
        {
            ShowMessageBox(text, caprion);
        }

        public bool OkCancelMessageBox(string text, string caprion)
        {
            return ShowMessageBox(text, caprion, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK ? true : false;
        }

        public DialogResult ShowMessageBox(string text, string caprion, MessageBoxButtons boxButtons = MessageBoxButtons.OK, MessageBoxIcon boxIcon = MessageBoxIcon.None, MessageBoxDefaultButton boxDefaultButton = MessageBoxDefaultButton.Button1)
        {
            return MessageBox.Show(text, caprion, boxButtons, boxIcon, boxDefaultButton);
        }

        private void OpenToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Open));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Open));
        }

        public string OpenFileDialog()
        {
            var open = new OpenFileDialog();
            return open.ShowDialog() == DialogResult.OK ? open.FileName : null;
        }

        private void NewToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.New));
        }

        private void createNewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.New));
        }

        public void ClearText()
        {
            textForEditingTextBox.Clear();
            _newOpen = true;
            DoEnabled(false);
        }

        private void SaveToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Save));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Save));
        }

        public string SaveFileDialog()
        {
            var fileForSave = new SaveFileDialog();
            return fileForSave.ShowDialog() == DialogResult.OK ? fileForSave.FileName : null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.SaveAs));
        }

        private void CopyToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Copy));
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Copy));
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Copy));
        }

        public void CopyText()
        {
            textForEditingTextBox.Copy();
        }

        private void CutToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Cut));
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Cut));
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Cut));
        }

        public void CutText()
        {
            textForEditingTextBox.Cut();
        }

        private void PasteToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Paste));
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Paste));
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Paste));
        }

        public void PasteText(string text)
        {
            textForEditingTextBox.Paste(text);
        }

        private void CancelToolStripLabel_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Cancel));
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Cancel));
        }


        private void cancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Cancel));
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClickOnButton(sender, new MyEventArgs(ButtonName.Exit));
        }

        private void ColorToolStripLabel_Click(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void ColorSettings()
        {
            var color = new ColorDialog
            {
                Color = CurForeColor
            };

            if (color.ShowDialog() == DialogResult.OK)
                CurForeColor = color.Color;
        }

        private void BackgroundToolStripLabel_Click(object sender, EventArgs e)
        {
            BackSettings();
        }

        private void textBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackSettings();
        }

        private void BackSettings()
        {
            var color = new ColorDialog
            {
                Color = CurBackColor
            };

            if (color.ShowDialog() == DialogResult.OK)
                CurBackColor = color.Color;
        }

        private void FontToolStripLabel_Click(object sender, EventArgs e)
        {
            FontSettings();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSettings();
        }

        private void FontSettings()
        {
            var font = new FontDialog
            {
                Font = CurFont
            };

            if (font.ShowDialog() == DialogResult.OK)
                CurFont = font.Font;
        }

        private void textForEditingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_newOpen)
            {
                _newOpen = false;
                DoEnabled(true);
            }
        }

        private void DoEnabled(bool enabled)
        {
            TextBoxMenuStrip.Enabled = enabled;
            editToolStripMenuItem.Enabled = enabled;
            CopyToolStripLabel.Enabled = enabled;
            CutToolStripLabel.Enabled = enabled;
            PasteToolStripLabel.Enabled = enabled;
            UndoToolStripLabel.Enabled = enabled;
        }
    }
}
