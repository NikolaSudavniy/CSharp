using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_03_EntryField
{
    public partial class Field : Form
    {
        public Field()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string Msg = "";
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }

                if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    Msg = "Click outside the rectangle";
                }
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    Msg = "Click on the border of the rectangle";
                }
                else
                {
                    Msg = "Click inside the rectangle";
                }
                MessageBox.Show(Msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = $"Window client area size - Width: {ClientSize.Width}, Height: {ClientSize.Height}";
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"Axis x {e.X} - Axis y {e.Y}";
        }
    }
}
