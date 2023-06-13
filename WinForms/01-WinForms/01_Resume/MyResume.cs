using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume
{
    public partial class Rsm : Form
    {
        public Rsm()
        {
            InitializeComponent();
        }

        private void ShowMsgBox(object sender, EventArgs e)
        {
            string[] myResume = { "Student: Nikola Sudavny",
                                  "Theme: Windows Forms base .NET",
                                  "Group: BPU1821",
                                  "Love cats",
                                  "Almost programmer"};
            int CountSymbol = 0;
            string caption;

            for (int i = 0; i < myResume.Length; i++)
            {
                CountSymbol += myResume[i].Length;
                if (i < myResume.Length - 1)
                {
                    caption = (myResume.Length - 1 == i) ? $"MessageBox {i + 1}" +
                    $"Average number of characters - " + $"{CountSymbol / myResume.Length}" : $"MessageBox {i + 1}";
                    MessageBox.Show(myResume[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    caption = (myResume.Length - 1 == i) ? $"MessageBox {i + 1}, " +
                    $"Average number of characters - " + $"{CountSymbol / myResume.Length}" : $"MessageBox {i + 1}";
                    MessageBox.Show(myResume[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
