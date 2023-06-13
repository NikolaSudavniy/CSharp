using System;
using System.Windows.Forms;

namespace QuestionaryApp
{
    public partial class AddQuestionaryForm : Form
    {
        public Questionary Questionary { get; private set; }

        public AddQuestionaryForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Questionary = null;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Questionary questionary = new Questionary();

            while (true)
            {
                try
                {
                    questionary.Name = nameTextBox.Text;
                    break;
                }
                catch (Exception)
                {
                    nameTextBox.Clear();
                    MessageBox.Show("Wrong Name! Try again.");
                    return;
                }
            }

            while (true)
            {
                try
                {
                    questionary.LastName = lastNameTextBox.Text;
                    break;
                }
                catch (Exception)
                {
                    lastNameTextBox.Clear();
                    MessageBox.Show("Wrong last name! Try again.");
                    return;
                }
            }

            while (true)
            {
                try
                {
                    questionary.Age = int.Parse(ageTextBox.Text);
                    break;
                }
                catch (Exception)
                {
                    ageTextBox.Clear();
                    MessageBox.Show("Wrong age! Try again.");
                    return;
                }
            }

            while (true)
            {
                try
                {
                    questionary.Number = numberTextBox.Text;
                    break;
                }
                catch (Exception)
                {
                    numberTextBox.Clear();
                    MessageBox.Show("Wrong number! Try again.");
                    return;
                }
            }

            Questionary = questionary;
            Close();
        }
    }
}