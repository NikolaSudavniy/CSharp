using System;
using System.IO;

using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string fileText= File.ReadAllText("site.t$");
            webBrowser.Navigate("file:///" + fileText);
        }
    }
}
