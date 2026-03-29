namespace NEA_Math_Program
{
    partial class Create_Question_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DifficultyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitQuestionBtn = new System.Windows.Forms.Button();
            this.BacktoMainMenuBtn = new System.Windows.Forms.Button();
            this.AnswerTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "In this menu, you can create questions that can be added to assignments.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write the expression here";
            // 
            // QuestionTxtBox
            // 
            this.QuestionTxtBox.Location = new System.Drawing.Point(15, 73);
            this.QuestionTxtBox.Name = "QuestionTxtBox";
            this.QuestionTxtBox.Size = new System.Drawing.Size(141, 20);
            this.QuestionTxtBox.TabIndex = 2;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(15, 123);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(141, 43);
            this.DescriptionTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Write the description of the question here";
            // 
            // DifficultyNumeric
            // 
            this.DifficultyNumeric.Location = new System.Drawing.Point(234, 123);
            this.DifficultyNumeric.Name = "DifficultyNumeric";
            this.DifficultyNumeric.ReadOnly = true;
            this.DifficultyNumeric.Size = new System.Drawing.Size(120, 20);
            this.DifficultyNumeric.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select a difficulty from 1-3 here.";
            // 
            // SubmitQuestionBtn
            // 
            this.SubmitQuestionBtn.Location = new System.Drawing.Point(15, 172);
            this.SubmitQuestionBtn.Name = "SubmitQuestionBtn";
            this.SubmitQuestionBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitQuestionBtn.TabIndex = 7;
            this.SubmitQuestionBtn.Text = "Submit Question";
            this.SubmitQuestionBtn.UseVisualStyleBackColor = true;
            this.SubmitQuestionBtn.Click += new System.EventHandler(this.SubmitQuestionBtn_Click);
            // 
            // BacktoMainMenuBtn
            // 
            this.BacktoMainMenuBtn.Location = new System.Drawing.Point(713, 172);
            this.BacktoMainMenuBtn.Name = "BacktoMainMenuBtn";
            this.BacktoMainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.BacktoMainMenuBtn.TabIndex = 21;
            this.BacktoMainMenuBtn.Text = "Main-Menu";
            this.BacktoMainMenuBtn.UseVisualStyleBackColor = true;
            this.BacktoMainMenuBtn.Click += new System.EventHandler(this.BacktoMainMenuBtn_Click);
            // 
            // AnswerTxtBox
            // 
            this.AnswerTxtBox.Location = new System.Drawing.Point(234, 73);
            this.AnswerTxtBox.Name = "AnswerTxtBox";
            this.AnswerTxtBox.Size = new System.Drawing.Size(141, 20);
            this.AnswerTxtBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Write the answer here";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Create_Question_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnswerTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BacktoMainMenuBtn);
            this.Controls.Add(this.SubmitQuestionBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DifficultyNumeric);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuestionTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_Question_Form";
            this.Text = "Create_Question_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuestionTxtBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DifficultyNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitQuestionBtn;
        private System.Windows.Forms.Button BacktoMainMenuBtn;
        private System.Windows.Forms.TextBox AnswerTxtBox;
        private System.Windows.Forms.Label label5;
    }
}