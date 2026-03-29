namespace NEA_Math_Program
{
    partial class Statistics_Menu
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
            this.AssignmentGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AssignmentIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentTitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewAssignmentBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).BeginInit();
            this.SuspendLayout();
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
            this.AssignmentGrid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Click on the assignment ID and then the button on the right in order to see how y" +
    "ou did.";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "In this menu, you can see how you did on previous assignments.";
            // 
            // ViewAssignmentBtn
            // 
            this.ViewAssignmentBtn.Location = new System.Drawing.Point(511, 83);
            this.ViewAssignmentBtn.Name = "ViewAssignmentBtn";
            this.ViewAssignmentBtn.Size = new System.Drawing.Size(125, 23);
            this.ViewAssignmentBtn.TabIndex = 13;
            this.ViewAssignmentBtn.Text = "View Assignment";
            this.ViewAssignmentBtn.UseVisualStyleBackColor = true;
            this.ViewAssignmentBtn.Click += new System.EventHandler(this.ViewAssignmentBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(1044, 383);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(125, 23);
            this.MainMenuBtn.TabIndex = 14;
            this.MainMenuBtn.Text = "Main-Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // Statistics_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 418);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.ViewAssignmentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssignmentGrid);
            this.Name = "Statistics_Menu";
            this.Text = "Statistics_Menu";
            this.Shown += new System.EventHandler(this.Statistics_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AssignmentGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentTitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentContentCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewAssignmentBtn;
        private System.Windows.Forms.Button MainMenuBtn;
    }
}