namespace Quiz_App
{
    partial class CreateQuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddQuestion = new Button();
            txtAnswer = new TextBox();
            txtQuestion = new TextBox();
            btnDone = new Button();
            SuspendLayout();
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(302, 190);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(128, 23);
            btnAddQuestion.TabIndex = 0;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(398, 142);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(279, 23);
            txtAnswer.TabIndex = 4;
            txtAnswer.Text = "Answer";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(71, 142);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(259, 23);
            txtQuestion.TabIndex = 5;
            txtQuestion.Text = "Question";
            // 
            // btnDone
            // 
            btnDone.Location = new Point(335, 289);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 6;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // CreateQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDone);
            Controls.Add(txtQuestion);
            Controls.Add(txtAnswer);
            Controls.Add(btnAddQuestion);
            Name = "CreateQuizForm";
            Text = "CreateQuizForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddQuestion;
        private TextBox txtAnswer;
        private TextBox txtQuestion;
        private Button btnDone;
    }
}