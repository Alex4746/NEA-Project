namespace NEA_Math_Program
{
    partial class View_Past_Assignment_Menu
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
            this.AssignmentGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssignmentDescLbl = new System.Windows.Forms.Label();
            this.AssignmentQuestionsGrid = new System.Windows.Forms.DataGridView();
            this.AssignedQuestionIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AssignmentTitleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.FeedbackLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeTakenLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ViewQuestionBtn = new System.Windows.Forms.Button();
            this.TimeTakenForQLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ResponseLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CorrectLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CorrectAnswerLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.AssignmentGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentQuestionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignmentGroup
            // 
            this.AssignmentGroup.Controls.Add(this.statusLbl);
            this.AssignmentGroup.Controls.Add(this.label5);
            this.AssignmentGroup.Controls.Add(this.BackBtn);
            this.AssignmentGroup.Controls.Add(this.CorrectAnswerLbl);
            this.AssignmentGroup.Controls.Add(this.label11);
            this.AssignmentGroup.Controls.Add(this.TimeTakenForQLbl);
            this.AssignmentGroup.Controls.Add(this.label12);
            this.AssignmentGroup.Controls.Add(this.ResponseLbl);
            this.AssignmentGroup.Controls.Add(this.label14);
            this.AssignmentGroup.Controls.Add(this.label15);
            this.AssignmentGroup.Controls.Add(this.CorrectLbl);
            this.AssignmentGroup.Controls.Add(this.ViewQuestionBtn);
            this.AssignmentGroup.Controls.Add(this.label10);
            this.AssignmentGroup.Controls.Add(this.TimeTakenLbl);
            this.AssignmentGroup.Controls.Add(this.label9);
            this.AssignmentGroup.Controls.Add(this.FeedbackLbl);
            this.AssignmentGroup.Controls.Add(this.ResultLbl);
            this.AssignmentGroup.Controls.Add(this.label8);
            this.AssignmentGroup.Controls.Add(this.label7);
            this.AssignmentGroup.Controls.Add(this.label2);
            this.AssignmentGroup.Controls.Add(this.label1);
            this.AssignmentGroup.Controls.Add(this.AssignmentDescLbl);
            this.AssignmentGroup.Controls.Add(this.AssignmentQuestionsGrid);
            this.AssignmentGroup.Controls.Add(this.label6);
            this.AssignmentGroup.Controls.Add(this.label3);
            this.AssignmentGroup.Controls.Add(this.label4);
            this.AssignmentGroup.Controls.Add(this.AssignmentTitleLbl);
            this.AssignmentGroup.Location = new System.Drawing.Point(12, 12);
            this.AssignmentGroup.Name = "AssignmentGroup";
            this.AssignmentGroup.Size = new System.Drawing.Size(1214, 590);
            this.AssignmentGroup.TabIndex = 22;
            this.AssignmentGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Here are the questions in the assignment";
            // 
            // AssignmentDescLbl
            // 
            this.AssignmentDescLbl.AutoSize = true;
            this.AssignmentDescLbl.Location = new System.Drawing.Point(6, 120);
            this.AssignmentDescLbl.Name = "AssignmentDescLbl";
            this.AssignmentDescLbl.Size = new System.Drawing.Size(60, 13);
            this.AssignmentDescLbl.TabIndex = 18;
            this.AssignmentDescLbl.Text = "Description";
            // 
            // AssignmentQuestionsGrid
            // 
            this.AssignmentQuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentQuestionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignedQuestionIDCol,
            this.DifficultyColumn,
            this.DescriptionColumn});
            this.AssignmentQuestionsGrid.Location = new System.Drawing.Point(6, 231);
            this.AssignmentQuestionsGrid.Name = "AssignmentQuestionsGrid";
            this.AssignmentQuestionsGrid.Size = new System.Drawing.Size(493, 321);
            this.AssignmentQuestionsGrid.TabIndex = 9;
            // 
            // AssignedQuestionIDCol
            // 
            this.AssignedQuestionIDCol.DataPropertyName = "QuestionID";
            this.AssignedQuestionIDCol.HeaderText = "Question ID";
            this.AssignedQuestionIDCol.Name = "AssignedQuestionIDCol";
            this.AssignedQuestionIDCol.Width = 75;
            // 
            // DifficultyColumn
            // 
            this.DifficultyColumn.DataPropertyName = "Difficulty";
            this.DifficultyColumn.HeaderText = "Difficulty";
            this.DifficultyColumn.Name = "DifficultyColumn";
            this.DifficultyColumn.Width = 75;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "Description";
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.Width = 300;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Assignment Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Here are the assignment details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description Of Assignment:";
            // 
            // AssignmentTitleLbl
            // 
            this.AssignmentTitleLbl.AutoSize = true;
            this.AssignmentTitleLbl.Location = new System.Drawing.Point(6, 69);
            this.AssignmentTitleLbl.Name = "AssignmentTitleLbl";
            this.AssignmentTitleLbl.Size = new System.Drawing.Size(27, 13);
            this.AssignmentTitleLbl.TabIndex = 14;
            this.AssignmentTitleLbl.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Here is the overview of how you did.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Result (%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Teacher feedback:";
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(442, 69);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(32, 13);
            this.ResultLbl.TabIndex = 22;
            this.ResultLbl.Text = "result";
            // 
            // FeedbackLbl
            // 
            this.FeedbackLbl.AutoSize = true;
            this.FeedbackLbl.Location = new System.Drawing.Point(442, 125);
            this.FeedbackLbl.Name = "FeedbackLbl";
            this.FeedbackLbl.Size = new System.Drawing.Size(52, 13);
            this.FeedbackLbl.TabIndex = 23;
            this.FeedbackLbl.Text = "feedback";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Time taken:";
            // 
            // TimeTakenLbl
            // 
            this.TimeTakenLbl.AutoSize = true;
            this.TimeTakenLbl.Location = new System.Drawing.Point(442, 96);
            this.TimeTakenLbl.Name = "TimeTakenLbl";
            this.TimeTakenLbl.Size = new System.Drawing.Size(53, 13);
            this.TimeTakenLbl.TabIndex = 25;
            this.TimeTakenLbl.Text = "timetaken";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(417, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Click on the question ID and then the button to see the details for that specific" +
    " question";
            // 
            // ViewQuestionBtn
            // 
            this.ViewQuestionBtn.Location = new System.Drawing.Point(508, 231);
            this.ViewQuestionBtn.Name = "ViewQuestionBtn";
            this.ViewQuestionBtn.Size = new System.Drawing.Size(138, 23);
            this.ViewQuestionBtn.TabIndex = 27;
            this.ViewQuestionBtn.Text = "View Question Details";
            this.ViewQuestionBtn.UseVisualStyleBackColor = true;
            this.ViewQuestionBtn.Click += new System.EventHandler(this.ViewQuestionBtn_Click);
            // 
            // TimeTakenForQLbl
            // 
            this.TimeTakenForQLbl.AutoSize = true;
            this.TimeTakenForQLbl.Location = new System.Drawing.Point(642, 288);
            this.TimeTakenForQLbl.Name = "TimeTakenForQLbl";
            this.TimeTakenForQLbl.Size = new System.Drawing.Size(27, 13);
            this.TimeTakenForQLbl.TabIndex = 33;
            this.TimeTakenForQLbl.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Time taken (s):";
            // 
            // ResponseLbl
            // 
            this.ResponseLbl.AutoSize = true;
            this.ResponseLbl.Location = new System.Drawing.Point(642, 317);
            this.ResponseLbl.Name = "ResponseLbl";
            this.ResponseLbl.Size = new System.Drawing.Size(27, 13);
            this.ResponseLbl.TabIndex = 31;
            this.ResponseLbl.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Correct?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Your Answer:";
            // 
            // CorrectLbl
            // 
            this.CorrectLbl.AutoSize = true;
            this.CorrectLbl.Location = new System.Drawing.Point(642, 261);
            this.CorrectLbl.Name = "CorrectLbl";
            this.CorrectLbl.Size = new System.Drawing.Size(27, 13);
            this.CorrectLbl.TabIndex = 28;
            this.CorrectLbl.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Correct Answer:";
            // 
            // CorrectAnswerLbl
            // 
            this.CorrectAnswerLbl.AutoSize = true;
            this.CorrectAnswerLbl.Location = new System.Drawing.Point(642, 344);
            this.CorrectAnswerLbl.Name = "CorrectAnswerLbl";
            this.CorrectAnswerLbl.Size = new System.Drawing.Size(27, 13);
            this.CorrectAnswerLbl.TabIndex = 35;
            this.CorrectAnswerLbl.Text = "N/A";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1133, 529);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 36;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Status:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(442, 42);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(35, 13);
            this.statusLbl.TabIndex = 38;
            this.statusLbl.Text = "status";
            // 
            // View_Past_Assignment_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 609);
            this.Controls.Add(this.AssignmentGroup);
            this.Name = "View_Past_Assignment_Menu";
            this.Text = "View_Past_Assignment_Menu";
            this.Shown += new System.EventHandler(this.View_Past_Assignment_Menu_Shown);
            this.AssignmentGroup.ResumeLayout(false);
            this.AssignmentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentQuestionsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AssignmentGroup;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AssignmentDescLbl;
        private System.Windows.Forms.DataGridView AssignmentQuestionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedQuestionIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AssignmentTitleLbl;
        private System.Windows.Forms.Label FeedbackLbl;
        private System.Windows.Forms.Label TimeTakenForQLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ResponseLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label CorrectLbl;
        private System.Windows.Forms.Button ViewQuestionBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimeTakenLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label CorrectAnswerLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label5;
    }
}