using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateStatics
{
    public partial class StaticSquare : Form
    {
        int oX { get; set; }
        int oY { get; set; }
        int numStatic { get; set; } = 1;

        public StaticSquare()
        {
            InitializeComponent();
            Text = "StaticApp";
            MouseDown += ThisMouseDown;
            MouseUp += ThisMouseUp;
        }

        private void ThisMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oX = e.X;
                oY = e.Y;
            }
        }

        private void ThisMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;
                if (e.X > oX && e.Y > oY)
                {
                    label.Location = new Point(oX, oY);
                }
                else if (e.X > oX && e.Y < oY)
                {
                    label.Location = new Point(oX, e.Y);
                }
                else if (e.X < oX && e.Y < oY)
                {
                    label.Location = new Point(e.X, e.Y);
                }
                else
                {
                    label.Location = new Point(e.X, oY);
                }
                if (Math.Abs(e.X - oX) <= 10 || Math.Abs(e.Y - oY) <= 10)
                {
                    MessageBox.Show("Impossible create «static» less than 10х10", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label.Size = new Size(Math.Abs(e.X - oX), Math.Abs(e.Y - oY));
                    label.Text = $"{numStatic}";
                    Controls.Add(label);
                    Text = $"«Static» №{label.Text} created!";
                    label.MouseClick += LabelMouseClick;
                    label.MouseDoubleClick += LabelMouseDoubleClick;
                    numStatic++;
                }
            }
            else
            {
                MessageBox.Show("For creating «static» press left mouse button", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        Text = $"«Static» №{item.Text}, Area {item.Width * item.Height}, Coordinates oХ = {item.Location.X} oY = {item.Location.Y}";
                    }
                }
            }
        }
        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int numLabel = numStatic;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (numLabel > Convert.ToInt32(item.Text))
                        {
                            numLabel = Convert.ToInt32(item.Text);
                        }
                    }
                }
                foreach (Label item in Controls)
                {
                    if (numLabel == Convert.ToInt32(item.Text))
                    {
                        Text = $"«Static» №{item.Text} deleted!";
                        Controls.Remove(item);
                        item.MouseClick -= LabelMouseClick;
                        item.MouseDoubleClick -= LabelMouseDoubleClick;
                    }
                }
            }
        }
    }
}
