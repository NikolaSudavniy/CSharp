using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GuessingGame : Form
    {
        public GuessingGame()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            DialogResult Result;
            int CountMsg = 1;
            while (true)
            {
                Result = MessageBox.Show($"{new Random().Next(1, 200)}", "You guessed the number", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    Result = MessageBox.Show($"Attempts count {CountMsg}", "Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CountMsg = 0;

                    this.Close();
                }
                CountMsg++;
            }
        }
    }
}
