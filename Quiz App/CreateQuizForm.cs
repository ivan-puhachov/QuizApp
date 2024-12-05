using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class CreateQuizForm : Form
    {
        private List<Question> questions;

        public CreateQuizForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            string questionText = txtQuestion.Text.Trim();
            string correctAnswer = txtAnswer.Text.Trim();

            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("Please fill in both question and answer fields.");
                return;
            }

            questions.Add(new Question { Text = questionText, CorrectAnswer = correctAnswer });
            txtQuestion.Clear();
            txtAnswer.Clear();

            MessageBox.Show("Question added successfully!");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
