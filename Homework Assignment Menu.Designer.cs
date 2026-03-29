namespace NEA_Math_Program
{
    partial class Homework_Assignment_Menu
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
            this.AssignedQuestionIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssignmentDueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AssignmentTitleLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AssignmentDescLbl = new System.Windows.Forms.Label();
            this.StartAssignmentBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new NEA_Math_Program.AssignmentsTableAdapters.TableAdapterManager();
            this.AssignmentGroup = new System.Windows.Forms.GroupBox();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).BeginInit();
            this.AssignmentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignmentGrid
            // 
            this.AssignmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignedQuestionIDCol,
            this.DifficultyColumn,
            this.DescriptionColumn});
            this.AssignmentGrid.Location = new System.Drawing.Point(6, 253);
            this.AssignmentGrid.Name = "AssignmentGrid";
            this.AssignmentGrid.Size = new System.Drawing.Size(493, 321);
            this.AssignmentGrid.TabIndex = 9;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Here are the questions in the assignment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "This menu is where you view and start your assignment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Here are the assignment details:";
            // 
            // AssignmentDueDatePicker
            // 
            this.AssignmentDueDatePicker.Location = new System.Drawing.Point(272, 65);
            this.AssignmentDueDatePicker.Name = "AssignmentDueDatePicker";
            this.AssignmentDueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AssignmentDueDatePicker.TabIndex = 13;
            // 
            // AssignmentTitleLbl
            // 
            this.AssignmentTitleLbl.AutoSize = true;
            this.AssignmentTitleLbl.Location = new System.Drawing.Point(6, 91);
            this.AssignmentTitleLbl.Name = "AssignmentTitleLbl";
            this.AssignmentTitleLbl.Size = new System.Drawing.Size(27, 13);
            this.AssignmentTitleLbl.TabIndex = 14;
            this.AssignmentTitleLbl.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description Of Assignment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Assignment Due-Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Assignment Title:";
            // 
            // AssignmentDescLbl
            // 
            this.AssignmentDescLbl.AutoSize = true;
            this.AssignmentDescLbl.Location = new System.Drawing.Point(6, 142);
            this.AssignmentDescLbl.Name = "AssignmentDescLbl";
            this.AssignmentDescLbl.Size = new System.Drawing.Size(60, 13);
            this.AssignmentDescLbl.TabIndex = 18;
            this.AssignmentDescLbl.Text = "Description";
            // 
            // StartAssignmentBtn
            // 
            this.StartAssignmentBtn.Location = new System.Drawing.Point(505, 253);
            this.StartAssignmentBtn.Name = "StartAssignmentBtn";
            this.StartAssignmentBtn.Size = new System.Drawing.Size(108, 23);
            this.StartAssignmentBtn.TabIndex = 19;
            this.StartAssignmentBtn.Text = "Start Assignment";
            this.StartAssignmentBtn.UseVisualStyleBackColor = true;
            this.StartAssignmentBtn.Click += new System.EventHandler(this.StartAssignmentBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "To start the assignment, press the button below.";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AssignmentsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = NEA_Math_Program.AssignmentsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AssignmentGroup
            // 
            this.AssignmentGroup.Controls.Add(this.label1);
            this.AssignmentGroup.Controls.Add(this.AssignmentDueDatePicker);
            this.AssignmentGroup.Controls.Add(this.AssignmentDescLbl);
            this.AssignmentGroup.Controls.Add(this.label5);
            this.AssignmentGroup.Controls.Add(this.label7);
            this.AssignmentGroup.Controls.Add(this.label2);
            this.AssignmentGroup.Controls.Add(this.AssignmentGrid);
            this.AssignmentGroup.Controls.Add(this.label6);
            this.AssignmentGroup.Controls.Add(this.StartAssignmentBtn);
            this.AssignmentGroup.Controls.Add(this.label3);
            this.AssignmentGroup.Controls.Add(this.label4);
            this.AssignmentGroup.Controls.Add(this.AssignmentTitleLbl);
            this.AssignmentGroup.Location = new System.Drawing.Point(12, 12);
            this.AssignmentGroup.Name = "AssignmentGroup";
            this.AssignmentGroup.Size = new System.Drawing.Size(925, 632);
            this.AssignmentGroup.TabIndex = 21;
            this.AssignmentGroup.TabStop = false;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(954, 28);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.MainMenuBtn.TabIndex = 22;
            this.MainMenuBtn.Text = "Main-Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // Homework_Assignment_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 651);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.AssignmentGroup);
            this.Name = "Homework_Assignment_Menu";
            this.Text = "Homework_Assignment_Menu";
            this.Shown += new System.EventHandler(this.Homework_Assignment_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGrid)).EndInit();
            this.AssignmentGroup.ResumeLayout(false);
            this.AssignmentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssignmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedQuestionIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker AssignmentDueDatePicker;
        private System.Windows.Forms.Label AssignmentTitleLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AssignmentDescLbl;
        private System.Windows.Forms.Button StartAssignmentBtn;
        private System.Windows.Forms.Label label7;
        private AssignmentsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox AssignmentGroup;
        private System.Windows.Forms.Button MainMenuBtn;
    }
}