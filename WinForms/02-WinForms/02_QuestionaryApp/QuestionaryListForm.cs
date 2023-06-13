using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionaryApp
{
    public partial class QuestionaryListForm : Form
    {
        private List<Questionary> questionaries;

        public QuestionaryListForm()
        {
            InitializeComponent();
            questionaries = new List<Questionary>();
        }

        private void addQuestionaryButton_Click(object sender, EventArgs e)
        {
            AddQuestionaryForm addForm = new AddQuestionaryForm();
            addForm.ShowDialog();

            if (addForm.Questionary != null)
            {
                questionaries.Add(addForm.Questionary);
                UpdateQuestionaryList();
            }
        }

        private void removeQuestionaryButton_Click(object sender, EventArgs e)
        {
            if (questionaryListBox.SelectedIndex >= 0)
            {
                questionaries.RemoveAt(questionaryListBox.SelectedIndex);
                UpdateQuestionaryList();
            }
            else
            {
                MessageBox.Show("No questionary selected!");
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            questionaries.Clear();
            UpdateQuestionaryList();
        }

        private void UpdateQuestionaryList()
        {
            questionaryListBox.Items.Clear();

            foreach (Questionary questionary in questionaries)
            {
                questionaryListBox.Items.Add(questionary);
            }
        }
    }
}