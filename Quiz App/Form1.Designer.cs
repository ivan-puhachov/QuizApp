namespace Quiz_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateQuiz = new Button();
            btnTakeQuiz = new Button();
            txtAnswer = new TextBox();
            lblQuestion = new Label();
            btnSubmitAnswer = new Button();
            SuspendLayout();
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.Location = new Point(13, 30);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(223, 122);
            btnCreateQuiz.TabIndex = 0;
            btnCreateQuiz.Text = "Create Quize";
            btnCreateQuiz.UseVisualStyleBackColor = true;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.Location = new Point(529, 30);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Size = new Size(216, 122);
            btnTakeQuiz.TabIndex = 1;
            btnTakeQuiz.Text = "Take Quiz";
            btnTakeQuiz.UseVisualStyleBackColor = true;
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(271, 258);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(199, 23);
            txtAnswer.TabIndex = 3;
            txtAnswer.Text = "Answer";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(322, 212);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(86, 15);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "Question Label";
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Location = new Point(333, 312);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(75, 23);
            btnSubmitAnswer.TabIndex = 6;
            btnSubmitAnswer.Text = "Submit";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(txtAnswer);
            Controls.Add(btnTakeQuiz);
            Controls.Add(btnCreateQuiz);
            Name = "Form1";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateQuiz;
        private Button btnTakeQuiz;
        private TextBox txtAnswer;
        private Label lblQuestion;
        private Button btnSubmitAnswer;
    }
}
