namespace NEA_Math_Program
{
    partial class Questions_For_Homework_Menu
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
            this.components = new System.ComponentModel.Container();
            this.QuestionsGrid = new System.Windows.Forms.DataGridView();
            this.QuestionIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new NEA_Math_Program.Database1DataSet1();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AddQuestionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.assignments = new NEA_Math_Program.Assignments();
            this.label3 = new System.Windows.Forms.Label();
            this.AssignmentGrid = new System.Windows.Forms.DataGridView();
            this.AssignedQuestionIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ManageAssignmentsBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.RemoveQuestionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionsGrid
            // 
            this.QuestionsGrid.AutoGenerateColumns = false;
            this.QuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionIDCol,
            this.DifficultyCol,
            this.DescriptionCol});
            this.QuestionsGrid.DataSource = this.database1DataSet1BindingSource1;
            this.QuestionsGrid.Location = new System.Drawing.Point(12, 56);
            this.QuestionsGrid.Name = "QuestionsGrid";
            this.QuestionsGrid.Size = new System.Drawing.Size(493, 300);
            this.QuestionsGrid.TabIndex = 0;
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
            // database1DataSet1BindingSource1
            // 
            this.database1DataSet1BindingSource1.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource1.Position = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here are all the questions you can add to the assignment you are creating.";
            // 
            // AddQuestionBtn
            // 
            this.AddQuestionBtn.Location = new System.Drawing.Point(520, 56);
            this.AddQuestionBtn.Name = "AddQuestionBtn";
            this.AddQuestionBtn.Size = new System.Drawing.Size(87, 23);
            this.AddQuestionBtn.TabIndex = 2;
            this.AddQuestionBtn.Text = "Add Question";
            this.AddQuestionBtn.UseVisualStyleBackColor = true;
            this.AddQuestionBtn.Click += new System.EventHandler(this.AddQuestionBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To add or remove a question, click on the question ID and then click the button.";
            // 
            // assignments
            // 
            this.assignments.DataSetName = "Assignments";
            this.assignments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "You will be able to see questions you\'ve added here in the grid below.";
            // 
            // AssignmentGrid
            // 
            this.AssignmentGrid.AutoGenerateColumns = false;
            this.AssignmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignedQuestionIDCol,
            this.DifficultyColumn,
            this.DescriptionColumn});
            this.AssignmentGrid.DataSource = this.database1DataSet1BindingSource2;
            this.AssignmentGrid.Location = new System.Drawing.Point(728, 56);
            this.AssignmentGrid.Name = "AssignmentGrid";
            this.AssignmentGrid.Size = new System.Drawing.Size(493, 300);
            this.AssignmentGrid.TabIndex = 5;
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
            // database1DataSet1BindingSource2
            // 
            this.database1DataSet1BindingSource2.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource2.Position = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Once you have finished adding questions to the homework assignment, press the but" +
    "ton below.";
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(15, 387);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 23);
            this.DoneBtn.TabIndex = 7;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "If you wish to change the details of your assignment, you can do so using the but" +
    "ton below.";
            // 
            // ManageAssignmentsBtn
            // 
            this.ManageAssignmentsBtn.Location = new System.Drawing.Point(728, 387);
            this.ManageAssignmentsBtn.Name = "ManageAssignmentsBtn";
            this.ManageAssignmentsBtn.Size = new System.Drawing.Size(165, 23);
            this.ManageAssignmentsBtn.TabIndex = 9;
            this.ManageAssignmentsBtn.Text = "Manage Assignment Details";
            this.ManageAssignmentsBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(1146, 437);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.MainMenuBtn.TabIndex = 10;
            this.MainMenuBtn.Text = "Main-Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // RemoveQuestionBtn
            // 
            this.RemoveQuestionBtn.Location = new System.Drawing.Point(520, 85);
            this.RemoveQuestionBtn.Name = "RemoveQuestionBtn";
            this.RemoveQuestionBtn.Size = new System.Drawing.Size(106, 23);
            this.RemoveQuestionBtn.TabIndex = 11;
            this.RemoveQuestionBtn.Text = "Remove Question";
            this.RemoveQuestionBtn.UseVisualStyleBackColor = true;
            this.RemoveQuestionBtn.Click += new System.EventHandler(this.RemoveQuestionBtn_Click);
            // 
            // Questions_For_Homework_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 661);
            this.Controls.Add(this.RemoveQuestionBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.ManageAssignmentsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AssignmentGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddQuestionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionsGrid);
            this.Name = "Questions_For_Homework_Menu";
            this.Text = "Questions_For_Homework_Menu";
            this.Shown += new System.EventHandler(this.Questions_For_Homework_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QuestionsGrid;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.Button AddQuestionBtn;
        private System.Windows.Forms.Label label2;
        private Assignments assignments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView AssignmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedQuestionIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource1;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ManageAssignmentsBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button RemoveQuestionBtn;
    }
}