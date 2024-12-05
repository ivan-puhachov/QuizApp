using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {

            InitializeComponent();
            btnTakeQuiz.Enabled = false;
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            // Open a new form to create a quiz
            var createForm = new CreateQuizForm(questions);
            createForm.ShowDialog();

            if (questions.Count > 0)
            {
                btnTakeQuiz.Enabled = true;
                MessageBox.Show("Quiz created successfully!");
            }
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("No questions available. Please create a quiz first.");
                return;
            }

            // Start the quiz
            currentQuestionIndex = 0;
            score = 0;
            ShowQuestion();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count)
            {
                string userAnswer = txtAnswer.Text.Trim();

                if (string.Equals(userAnswer, questions[currentQuestionIndex].CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }

                currentQuestionIndex++;

                if (currentQuestionIndex < questions.Count)
                {
                    ShowQuestion();
                }
                else
                {
                    MessageBox.Show($"Quiz finished! Your score: {score}/{questions.Count}");
                }
            }
        }
        private void ShowQuestion()
        {
            lblQuestion.Text = questions[currentQuestionIndex].Text;
            txtAnswer.Clear();
        }
    }
    public class Question
    {
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
