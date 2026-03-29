namespace NEA_Math_Program
{
    partial class Teacher_Main_Menu
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
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.TeacherNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignHomeworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(716, 382);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(84, 24);
            this.LogOutBtn.TabIndex = 11;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // TeacherNameLbl
            // 
            this.TeacherNameLbl.AutoSize = true;
            this.TeacherNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherNameLbl.Location = new System.Drawing.Point(113, 5);
            this.TeacherNameLbl.Name = "TeacherNameLbl";
            this.TeacherNameLbl.Size = new System.Drawing.Size(68, 25);
            this.TeacherNameLbl.TabIndex = 9;
            this.TeacherNameLbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classManagementToolStripMenuItem,
            this.assignHomeworkToolStripMenuItem,
            this.progressReviewToolStripMenuItem,
            this.createQuestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 387);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classManagementToolStripMenuItem
            // 
            this.classManagementToolStripMenuItem.Name = "classManagementToolStripMenuItem";
            this.classManagementToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.classManagementToolStripMenuItem.Text = "Class Management";
            this.classManagementToolStripMenuItem.Click += new System.EventHandler(this.classManagementToolStripMenuItem_Click);
            // 
            // assignHomeworkToolStripMenuItem
            // 
            this.assignHomeworkToolStripMenuItem.Name = "assignHomeworkToolStripMenuItem";
            this.assignHomeworkToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.assignHomeworkToolStripMenuItem.Text = "Assign Homework";
            this.assignHomeworkToolStripMenuItem.Click += new System.EventHandler(this.assignHomeworkToolStripMenuItem_Click);
            // 
            // progressReviewToolStripMenuItem
            // 
            this.progressReviewToolStripMenuItem.Name = "progressReviewToolStripMenuItem";
            this.progressReviewToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.progressReviewToolStripMenuItem.Text = "Progress Review";
            this.progressReviewToolStripMenuItem.Click += new System.EventHandler(this.progressReviewToolStripMenuItem_Click);
            // 
            // createQuestionToolStripMenuItem
            // 
            this.createQuestionToolStripMenuItem.Name = "createQuestionToolStripMenuItem";
            this.createQuestionToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.createQuestionToolStripMenuItem.Text = "Create Question";
            this.createQuestionToolStripMenuItem.Click += new System.EventHandler(this.createQuestionToolStripMenuItem_Click);
            // 
            // Teacher_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.TeacherNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Teacher_Main_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Teacher_Main_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label TeacherNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignHomeworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQuestionToolStripMenuItem;
    }
}