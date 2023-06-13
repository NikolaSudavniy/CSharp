using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarLoader
{
    public partial class ProgressBarLoaderForm : Form
    {
        private string _fileName;
        private ActionWithFiles _action;

        public ProgressBarLoaderForm()
        {
            InitializeComponent();

            progressBar.Minimum = 0;
            progressBar.Maximum = 50;
            progressBar.Step = 1;
            progressBar.Visible = false;
        }

        private bool GetFileName()
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return false;

            _fileName = openFileDialog.FileName;
            return true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!GetFileName())
                return;

            progressBar.Visible = true;

            try
            {
                var byteList = ReadFileByBytes(_fileName, progressBar);

                if (!DoSomethingWithFile(ref byteList, _fileName, textFileRadioButton.Checked))
                    MessageBox.Show("File is empty!", "Oops");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                progressBar.Visible = false;
            }
        }

        private void ProgressBarLoaderForm_Load(object sender, EventArgs e)
        {
            // Инициализация формы или другая логика загрузки
        }

        private List<byte> ReadFileByBytes(string fileName, ProgressBar progressBar)
        {
            if (!File.Exists(fileName))
                throw new Exception("List<byte> ReadFileByBytes: Файл не существует");

            var byteList = new List<byte>();

            using (var fileStream = File.OpenRead(fileName))
            {
                if (fileStream.Length > 10485760)
                {
                    MessageBox.Show("Пожалуйста, выберите файл размером менее 10 МБ");
                    return null;
                }

                double stepSize = fileStream.Length / progressBar.Maximum;

                while (fileStream.Position != fileStream.Length)
                {
                    byteList.Add((byte)fileStream.ReadByte());

                    if (byteList.Count != 0 && byteList.Count % stepSize == 0)
                        progressBar.PerformStep();
                }
            }

            return byteList;
        }

        private bool DoSomethingWithFile(ref List<byte> byteList, string fileName, bool isTextFile)
        {
            if (byteList == null || byteList.Count == 0)
                return false;

            if (isTextFile)
                _action = new ActionWithTextFile();
            else
                _action = new ActionWithByteFile();

            _action.Do(ref byteList, fileName);

            return true;
        }
    }
}
