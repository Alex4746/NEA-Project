namespace NEA_Math_Program
{
    partial class Answer_Question
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.AnswerTxtBox = new System.Windows.Forms.TextBox();
            this.SubmitAnswerBtn = new System.Windows.Forms.Button();
            this.QuestionsLeftLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here is the question:";
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Location = new System.Drawing.Point(12, 32);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(49, 13);
            this.QuestionLbl.TabIndex = 1;
            this.QuestionLbl.Text = "Question";
            // 
            // AnswerTxtBox
            // 
            this.AnswerTxtBox.Location = new System.Drawing.Point(228, 116);
            this.AnswerTxtBox.Name = "AnswerTxtBox";
            this.AnswerTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerTxtBox.TabIndex = 3;
            // 
            // SubmitAnswerBtn
            // 
            this.SubmitAnswerBtn.Location = new System.Drawing.Point(334, 114);
            this.SubmitAnswerBtn.Name = "SubmitAnswerBtn";
            this.SubmitAnswerBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitAnswerBtn.TabIndex = 4;
            this.SubmitAnswerBtn.Text = "Submit Answer";
            this.SubmitAnswerBtn.UseVisualStyleBackColor = true;
            this.SubmitAnswerBtn.Click += new System.EventHandler(this.SubmitAnswerBtn_Click);
            // 
            // QuestionsLeftLbl
            // 
            this.QuestionsLeftLbl.AutoSize = true;
            this.QuestionsLeftLbl.Location = new System.Drawing.Point(12, 168);
            this.QuestionsLeftLbl.Name = "QuestionsLeftLbl";
            this.QuestionsLeftLbl.Size = new System.Drawing.Size(129, 13);
            this.QuestionsLeftLbl.TabIndex = 5;
            this.QuestionsLeftLbl.Text = "You have x questions left.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To go back to the homework menu, press the button below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer here -";
            // 
            // Answer_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuestionsLeftLbl);
            this.Controls.Add(this.SubmitAnswerBtn);
            this.Controls.Add(this.AnswerTxtBox);
            this.Controls.Add(this.QuestionLbl);
            this.Controls.Add(this.label1);
            this.Name = "Answer_Question";
            this.Text = "Answer_Question";
            this.Load += new System.EventHandler(this.Answer_Question_Load);
            this.Shown += new System.EventHandler(this.Answer_Question_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuestionLbl;
        private System.Windows.Forms.TextBox AnswerTxtBox;
        private System.Windows.Forms.Button SubmitAnswerBtn;
        private System.Windows.Forms.Label QuestionsLeftLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}