using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRunStatic
{
    public partial class RunStatic : Form
    {
        public RunStatic()
        {
            InitializeComponent();
            this.Load += RunStaticLoad;
            this.MouseMove += RunStaticMouseMove;
        }

        private void RunStaticLoad(object sender, EventArgs e)
        {
            omnomnom.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(omnomnom);
            LableCenter(omnomnom);
        }

        private void RunStaticMouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > omnomnom.Location.X - 20 && e.X < omnomnom.Location.X + omnomnom.Width + 20) && (e.Y > omnomnom.Location.Y - 20 && e.Y < omnomnom.Location.Y + omnomnom.Height + 20))
            {
                if (e.X > omnomnom.Location.X - 20 && e.X < omnomnom.Location.X)
                {
                    omnomnom.Left += 10;
                }
                else if (e.X < omnomnom.Location.X + omnomnom.Width + 20 && e.X > omnomnom.Location.X + omnomnom.Width)
                {
                    omnomnom.Left -= 10;
                }
                else if (e.Y > omnomnom.Location.Y - 20 && e.Y < omnomnom.Location.Y)
                {
                    omnomnom.Top += 10;
                }
                else if (e.Y < omnomnom.Location.Y + omnomnom.Height + 20 && e.Y > omnomnom.Location.Y + omnomnom.Height)
                {
                    omnomnom.Top -= 10;
                }
                if ((omnomnom.Location.X < 0 || omnomnom.Location.X > ClientSize.Width - omnomnom.Width) || (omnomnom.Location.Y < 0 || omnomnom.Location.Y > ClientSize.Height - omnomnom.Height))
                {
                    LableCenter(omnomnom);
                }
            }
        }

        void LableCenter(Label lable)
        {
            omnomnom.Left = (ClientSize.Width - omnomnom.Size.Width) / 2;
            omnomnom.Top = (ClientSize.Height - omnomnom.Size.Height) / 2;
        }

        private void RunStatic_Load(object sender, EventArgs e)
        {

        }

        private void omnomnom_Click(object sender, EventArgs e)
        {

        }
    }
}