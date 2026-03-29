namespace NEA_Math_Program
{
    partial class Practice_Menu
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
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.QuestionsGrid = new System.Windows.Forms.DataGridView();
            this.QuestionIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectQuestionBtn = new System.Windows.Forms.Button();
            this.SearchQuestionsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KeywordTxtBox = new System.Windows.Forms.TextBox();
            this.QuestionIDNumeric = new System.Windows.Forms.NumericUpDown();
            this.DifficultyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomQBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlgebraicBtn = new System.Windows.Forms.RadioButton();
            this.ArithmeticBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.RandomQDiffNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionIDNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomQDiffNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(1097, 486);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(125, 23);
            this.MainMenuBtn.TabIndex = 16;
            this.MainMenuBtn.Text = "Main-Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // QuestionsGrid
            // 
            this.QuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionIDCol,
            this.DifficultyCol,
            this.DescriptionCol});
            this.QuestionsGrid.Location = new System.Drawing.Point(12, 27);
            this.QuestionsGrid.Name = "QuestionsGrid";
            this.QuestionsGrid.Size = new System.Drawing.Size(493, 300);
            this.QuestionsGrid.TabIndex = 17;
            // 
            // QuestionIDCol
            // 
            this.QuestionIDCol.DataPropertyName = "QuestionID";
            this.QuestionIDCol.HeaderText = "Question ID";
            this.QuestionIDCol.Name = "QuestionIDCol";
            this.QuestionIDCol.Width = 75;
            // 
            // DifficultyCol
            // 
            this.DifficultyCol.DataPropertyName = "Difficulty";
            this.DifficultyCol.HeaderText = "Difficulty";
            this.DifficultyCol.Name = "DifficultyCol";
            this.DifficultyCol.Width = 75;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.DataPropertyName = "Description";
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.Width = 300;
            // 
            // SelectQuestionBtn
            // 
            this.SelectQuestionBtn.Location = new System.Drawing.Point(511, 304);
            this.SelectQuestionBtn.Name = "SelectQuestionBtn";
            this.SelectQuestionBtn.Size = new System.Drawing.Size(102, 23);
            this.SelectQuestionBtn.TabIndex = 18;
            this.SelectQuestionBtn.Text = "Select Question";
            this.SelectQuestionBtn.UseVisualStyleBackColor = true;
            this.SelectQuestionBtn.Click += new System.EventHandler(this.SelectQuestionBtn_Click);
            // 
            // SearchQuestionsBtn
            // 
            this.SearchQuestionsBtn.Location = new System.Drawing.Point(511, 105);
            this.SearchQuestionsBtn.Name = "SearchQuestionsBtn";
            this.SearchQuestionsBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchQuestionsBtn.TabIndex = 19;
            this.SearchQuestionsBtn.Text = "Search";
            this.SearchQuestionsBtn.UseVisualStyleBackColor = true;
            this.SearchQuestionsBtn.Click += new System.EventHandler(this.SearchQuestionsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "You can search using keywords (such as addition, substraction, etc), by difficult" +
    "y, or by question ID.";
            // 
            // KeywordTxtBox
            // 
            this.KeywordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeywordTxtBox.Location = new System.Drawing.Point(513, 27);
            this.KeywordTxtBox.Name = "KeywordTxtBox";
            this.KeywordTxtBox.Size = new System.Drawing.Size(121, 20);
            this.KeywordTxtBox.TabIndex = 21;
            // 
            // QuestionIDNumeric
            // 
            this.QuestionIDNumeric.Location = new System.Drawing.Point(514, 80);
            this.QuestionIDNumeric.Name = "QuestionIDNumeric";
            this.QuestionIDNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuestionIDNumeric.TabIndex = 22;
            // 
            // DifficultyNumeric
            // 
            this.DifficultyNumeric.Location = new System.Drawing.Point(514, 53);
            this.DifficultyNumeric.Name = "DifficultyNumeric";
            this.DifficultyNumeric.Size = new System.Drawing.Size(120, 20);
            this.DifficultyNumeric.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "- Question ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "- Difficulty";
            // 
            // RandomQBtn
            // 
            this.RandomQBtn.Location = new System.Drawing.Point(12, 486);
            this.RandomQBtn.Name = "RandomQBtn";
            this.RandomQBtn.Size = new System.Drawing.Size(113, 23);
            this.RandomQBtn.TabIndex = 26;
            this.RandomQBtn.Text = "Random Question";
            this.RandomQBtn.UseVisualStyleBackColor = true;
            this.RandomQBtn.Click += new System.EventHandler(this.RandomQBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "To do a randomly generated question, select a question type and difficulty, then " +
    "click the button below.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AlgebraicBtn);
            this.panel1.Controls.Add(this.ArithmeticBtn);
            this.panel1.Location = new System.Drawing.Point(15, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 51);
            this.panel1.TabIndex = 28;
            // 
            // AlgebraicBtn
            // 
            this.AlgebraicBtn.AutoSize = true;
            this.AlgebraicBtn.Location = new System.Drawing.Point(3, 3);
            this.AlgebraicBtn.Name = "AlgebraicBtn";
            this.AlgebraicBtn.Size = new System.Drawing.Size(84, 17);
            this.AlgebraicBtn.TabIndex = 30;
            this.AlgebraicBtn.TabStop = true;
            this.AlgebraicBtn.Text = "1 - Algebraic";
            this.AlgebraicBtn.UseVisualStyleBackColor = true;
            // 
            // ArithmeticBtn
            // 
            this.ArithmeticBtn.AutoSize = true;
            this.ArithmeticBtn.Location = new System.Drawing.Point(3, 26);
            this.ArithmeticBtn.Name = "ArithmeticBtn";
            this.ArithmeticBtn.Size = new System.Drawing.Size(86, 17);
            this.ArithmeticBtn.TabIndex = 29;
            this.ArithmeticBtn.TabStop = true;
            this.ArithmeticBtn.Text = "2 - Arithmetic";
            this.ArithmeticBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "- Keyword";
            // 
            // RandomQDiffNumeric
            // 
            this.RandomQDiffNumeric.Location = new System.Drawing.Point(15, 463);
            this.RandomQDiffNumeric.Name = "RandomQDiffNumeric";
            this.RandomQDiffNumeric.Size = new System.Drawing.Size(110, 20);
            this.RandomQDiffNumeric.TabIndex = 30;
            // 
            // Practice_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 521);
            this.Controls.Add(this.RandomQDiffNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RandomQBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DifficultyNumeric);
            this.Controls.Add(this.QuestionIDNumeric);
            this.Controls.Add(this.KeywordTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchQuestionsBtn);
            this.Controls.Add(this.SelectQuestionBtn);
            this.Controls.Add(this.QuestionsGrid);
            this.Controls.Add(this.MainMenuBtn);
            this.Name = "Practice_Menu";
            this.Text = "Practice_Menu";
            this.Shown += new System.EventHandler(this.Practice_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionIDNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomQDiffNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.DataGridView QuestionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.Button SelectQuestionBtn;
        private System.Windows.Forms.Button SearchQuestionsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeywordTxtBox;
        private System.Windows.Forms.NumericUpDown QuestionIDNumeric;
        private System.Windows.Forms.NumericUpDown DifficultyNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RandomQBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton AlgebraicBtn;
        private System.Windows.Forms.RadioButton ArithmeticBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RandomQDiffNumeric;
    }
}