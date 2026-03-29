namespace NEA_Math_Program
{
    partial class Student_Assignments_Menu
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
            this.ViewAssignmentBtn = new System.Windows.Forms.Button();
            this.StudentNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AssignmentGrid = new System.Windows.Forms.DataGridView();
            this.AssignmentIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentTitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAssignmentBtn
            // 
            this.ViewAssignmentBtn.Location = new System.Drawing.Point(511, 83);
            this.ViewAssignmentBtn.Name = "ViewAssignmentBtn";
            this.ViewAssignmentBtn.Size = new System.Drawing.Size(125, 23);
            this.ViewAssignmentBtn.TabIndex = 18;
            this.ViewAssignmentBtn.Text = "View Assignment";
            this.ViewAssignmentBtn.UseVisualStyleBackColor = true;
            this.ViewAssignmentBtn.Click += new System.EventHandler(this.ViewAssignmentBtn_Click);
            // 
            // StudentNameLbl
            // 
            this.StudentNameLbl.AutoSize = true;
            this.StudentNameLbl.Location = new System.Drawing.Point(12, 9);
            this.StudentNameLbl.Name = "StudentNameLbl";
            this.StudentNameLbl.Size = new System.Drawing.Size(164, 13);
            this.StudentNameLbl.TabIndex = 17;
            this.StudentNameLbl.Text = "You are viewing X\'s assignments.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select the assignment ID from the table and then click the button to see how they" +
    " did.";
            // 
            // AssignmentGrid
            // 
            this.AssignmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentIDCol,
            this.AssignmentTitleCol,
            this.AssignmentContentCol});
            this.AssignmentGrid.Location = new System.Drawing.Point(12, 85);
            this.AssignmentGrid.Name = "AssignmentGrid";
            this.AssignmentGrid.Size = new System.Drawing.Size(493, 321);
            this.AssignmentGrid.TabIndex = 15;
            // 
            // AssignmentIDCol
            // 
            this.AssignmentIDCol.DataPropertyName = "AssignmentID";
            this.AssignmentIDCol.HeaderText = "Assignment ID";
            this.AssignmentIDCol.Name = "AssignmentIDCol";
            // 
            // AssignmentTitleCol
            // 
            this.AssignmentTitleCol.DataPropertyName = "Title";
            this.AssignmentTitleCol.HeaderText = "Title";
            this.AssignmentTitleCol.Name = "AssignmentTitleCol";
            // 
            // AssignmentContentCol
            // 
            this.AssignmentContentCol.DataPropertyName = "Content";
            this.AssignmentContentCol.HeaderText = "Content";
            this.AssignmentContentCol.Name = "AssignmentContentCol";
            this.AssignmentContentCol.Width = 250;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(923, 383);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Student_Assignments_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 429);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ViewAssignmentBtn);
            this.Controls.Add(this.StudentNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssignmentGrid);
            this.Name = "Student_Assignments_Menu";
            this.Text = "Student_Assignments_Menu";
            this.Shown += new System.EventHandler(this.Student_Assignments_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewAssignmentBtn;
        private System.Windows.Forms.Label StudentNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AssignmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentTitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentContentCol;
        private System.Windows.Forms.Button BackBtn;
    }
}