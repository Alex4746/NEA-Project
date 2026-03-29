namespace NEA_Math_Program
{
    partial class Progress_Review_Menu
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
            this.ViewAssignmentsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
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
            this.StudentGrid.Location = new System.Drawing.Point(12, 25);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(600, 324);
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
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Here, you can see and give feedback on your students\' past assignments.";
            // 
            // ViewAssignmentsBtn
            // 
            this.ViewAssignmentsBtn.Location = new System.Drawing.Point(616, 25);
            this.ViewAssignmentsBtn.Name = "ViewAssignmentsBtn";
            this.ViewAssignmentsBtn.Size = new System.Drawing.Size(127, 23);
            this.ViewAssignmentsBtn.TabIndex = 3;
            this.ViewAssignmentsBtn.Text = "View Assignments";
            this.ViewAssignmentsBtn.UseVisualStyleBackColor = true;
            this.ViewAssignmentsBtn.Click += new System.EventHandler(this.ViewAssignmentsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the student ID and then click the button to see all their past assignments" +
    ".";
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(871, 326);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(125, 23);
            this.MainMenuBtn.TabIndex = 15;
            this.MainMenuBtn.Text = "Main-Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // Progress_Review_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 361);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewAssignmentsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentGrid);
            this.Name = "Progress_Review_Menu";
            this.Text = "Progress_Review_Menu";
            this.Shown += new System.EventHandler(this.Progress_Review_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
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
        private System.Windows.Forms.Button ViewAssignmentsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MainMenuBtn;
    }
}