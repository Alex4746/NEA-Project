namespace NEA_Math_Program
{
    partial class Assign_Homework_Menu
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
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssignHmwrkClassBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateAssignmentBtn = new System.Windows.Forms.Button();
            this.AssignmentGrid = new System.Windows.Forms.DataGridView();
            this.AssignedQuestionIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AssignHmwrkBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ManageAssignmentBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGrid
            // 
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.StudentIDColumn,
            this.EmailColumn});
            this.StudentGrid.Location = new System.Drawing.Point(12, 131);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(600, 321);
            this.StudentGrid.TabIndex = 1;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First Name";
            this.FirstNameColumn.Name = "FirstNameColumn";
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            // 
            // StudentIDColumn
            // 
            this.StudentIDColumn.DataPropertyName = "StudentID";
            this.StudentIDColumn.HeaderText = "StudentID";
            this.StudentIDColumn.Name = "StudentIDColumn";
            this.StudentIDColumn.Width = 75;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 325;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Here is your class.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "This is the menu where you assign homework to your students. \r\nYou can assign hom" +
    "ework to the whole class or specific students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To assign homework to the entire class, press the button below.";
            // 
            // AssignHmwrkClassBtn
            // 
            this.AssignHmwrkClassBtn.Location = new System.Drawing.Point(15, 471);
            this.AssignHmwrkClassBtn.Name = "AssignHmwrkClassBtn";
            this.AssignHmwrkClassBtn.Size = new System.Drawing.Size(152, 23);
            this.AssignHmwrkClassBtn.TabIndex = 5;
            this.AssignHmwrkClassBtn.Text = "Assign Homework to class";
            this.AssignHmwrkClassBtn.UseVisualStyleBackColor = true;
            this.AssignHmwrkClassBtn.Click += new System.EventHandler(this.AssignHmwrkClassBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Before you can do that though, you must first create the assignment.\r\nYou can do " +
    "this by pressing the button below and following the instructions.";
            // 
            // CreateAssignmentBtn
            // 
            this.CreateAssignmentBtn.Location = new System.Drawing.Point(12, 74);
            this.CreateAssignmentBtn.Name = "CreateAssignmentBtn";
            this.CreateAssignmentBtn.Size = new System.Drawing.Size(122, 23);
            this.CreateAssignmentBtn.TabIndex = 7;
            this.CreateAssignmentBtn.Text = "Create Assignment";
            this.CreateAssignmentBtn.UseVisualStyleBackColor = true;
            this.CreateAssignmentBtn.Click += new System.EventHandler(this.CreateAssignmentBtn_Click);
            // 
            // AssignmentGrid
            // 
            this.AssignmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignedQuestionIDCol,
            this.DifficultyColumn,
            this.DescriptionColumn});
            this.AssignmentGrid.Location = new System.Drawing.Point(727, 131);
            this.AssignmentGrid.Name = "AssignmentGrid";
            this.AssignmentGrid.Size = new System.Drawing.Size(493, 321);
            this.AssignmentGrid.TabIndex = 8;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Here is your assignment.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(507, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "To assign homework to a specific student, select their student ID from the grid a" +
    "nd press the button below.";
            // 
            // AssignHmwrkBtn
            // 
            this.AssignHmwrkBtn.Location = new System.Drawing.Point(15, 513);
            this.AssignHmwrkBtn.Name = "AssignHmwrkBtn";
            this.AssignHmwrkBtn.Size = new System.Drawing.Size(152, 23);
            this.AssignHmwrkBtn.TabIndex = 11;
            this.AssignHmwrkBtn.Text = "Assign Homework";
            this.AssignHmwrkBtn.UseVisualStyleBackColor = true;
            this.AssignHmwrkBtn.Click += new System.EventHandler(this.AssignHmwrkBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "You can manage your assignment using this button.";
            // 
            // ManageAssignmentBtn
            // 
            this.ManageAssignmentBtn.Location = new System.Drawing.Point(727, 74);
            this.ManageAssignmentBtn.Name = "ManageAssignmentBtn";
            this.ManageAssignmentBtn.Size = new System.Drawing.Size(138, 23);
            this.ManageAssignmentBtn.TabIndex = 14;
            this.ManageAssignmentBtn.Text = "Manage Assignment";
            this.ManageAssignmentBtn.UseVisualStyleBackColor = true;
            this.ManageAssignmentBtn.Click += new System.EventHandler(this.ManageAssignmentBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(1145, 458);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.MainMenuBtn.TabIndex = 15;
            this.MainMenuBtn.Text = "Main-Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // Assign_Homework_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.ManageAssignmentBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AssignHmwrkBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AssignmentGrid);
            this.Controls.Add(this.CreateAssignmentBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AssignHmwrkClassBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentGrid);
            this.Name = "Assign_Homework_Menu";
            this.Text = "Assign Homework Menu";
            this.Load += new System.EventHandler(this.Assign_Homework_Menu_Load);
            this.Shown += new System.EventHandler(this.Assign_Homework_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AssignHmwrkClassBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateAssignmentBtn;
        private System.Windows.Forms.DataGridView AssignmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedQuestionIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AssignHmwrkBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ManageAssignmentBtn;
        private System.Windows.Forms.Button MainMenuBtn;
    }
}