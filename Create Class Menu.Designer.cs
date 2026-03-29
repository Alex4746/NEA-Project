namespace NEA_Math_Program
{
    partial class Create_Class_Menu
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
            this.StudentsToAddGrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new NEA_Math_Program.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddStdntPanel = new System.Windows.Forms.Panel();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.SearchStdntsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IDNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddStdntToClassBtn = new System.Windows.Forms.Button();
            this.CreateClassPanel = new System.Windows.Forms.Panel();
            this.CreateClassBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsToAddGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.AddStdntPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumeric)).BeginInit();
            this.CreateClassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsToAddGrid
            // 
            this.StudentsToAddGrid.AutoGenerateColumns = false;
            this.StudentsToAddGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsToAddGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LastNameColumn,
            this.EmailColumn,
            this.StudentIDColumn});
            this.StudentsToAddGrid.DataSource = this.database1DataSetBindingSource;
            this.StudentsToAddGrid.Location = new System.Drawing.Point(6, 44);
            this.StudentsToAddGrid.Name = "StudentsToAddGrid";
            this.StudentsToAddGrid.Size = new System.Drawing.Size(418, 300);
            this.StudentsToAddGrid.TabIndex = 0;
            this.StudentsToAddGrid.AllowUserToAddRowsChanged += new System.EventHandler(this.False);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "FirstName";
            this.NameColumn.HeaderText = "First Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 125;
            // 
            // StudentIDColumn
            // 
            this.StudentIDColumn.DataPropertyName = "StudentID";
            this.StudentIDColumn.HeaderText = "Student ID";
            this.StudentIDColumn.Name = "StudentIDColumn";
            this.StudentIDColumn.Width = 50;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here, you are able to search through the students to find their ID.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Using their ID you can add the student to your class by clicking the button below" +
    ".";
            // 
            // AddStdntPanel
            // 
            this.AddStdntPanel.Controls.Add(this.DoneBtn);
            this.AddStdntPanel.Controls.Add(this.SearchStdntsBtn);
            this.AddStdntPanel.Controls.Add(this.label5);
            this.AddStdntPanel.Controls.Add(this.IDNumeric);
            this.AddStdntPanel.Controls.Add(this.label6);
            this.AddStdntPanel.Controls.Add(this.NameTxtBox);
            this.AddStdntPanel.Controls.Add(this.label7);
            this.AddStdntPanel.Controls.Add(this.label4);
            this.AddStdntPanel.Controls.Add(this.AddStdntToClassBtn);
            this.AddStdntPanel.Controls.Add(this.label1);
            this.AddStdntPanel.Controls.Add(this.label2);
            this.AddStdntPanel.Controls.Add(this.StudentsToAddGrid);
            this.AddStdntPanel.Location = new System.Drawing.Point(459, 12);
            this.AddStdntPanel.Name = "AddStdntPanel";
            this.AddStdntPanel.Size = new System.Drawing.Size(680, 537);
            this.AddStdntPanel.TabIndex = 3;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(6, 448);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 23);
            this.DoneBtn.TabIndex = 15;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // SearchStdntsBtn
            // 
            this.SearchStdntsBtn.Location = new System.Drawing.Point(529, 94);
            this.SearchStdntsBtn.Name = "SearchStdntsBtn";
            this.SearchStdntsBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchStdntsBtn.TabIndex = 14;
            this.SearchStdntsBtn.Text = "Search";
            this.SearchStdntsBtn.UseVisualStyleBackColor = true;
            this.SearchStdntsBtn.Click += new System.EventHandler(this.SearchStdntsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // IDNumeric
            // 
            this.IDNumeric.Location = new System.Drawing.Point(33, 396);
            this.IDNumeric.Name = "IDNumeric";
            this.IDNumeric.Size = new System.Drawing.Size(120, 20);
            this.IDNumeric.TabIndex = 12;
            this.IDNumeric.ValueChanged += new System.EventHandler(this.IDNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(486, 68);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(118, 20);
            this.NameTxtBox.TabIndex = 10;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NameTxtBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "You can search by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "If you are done adding students to your class, press the button below.";
            // 
            // AddStdntToClassBtn
            // 
            this.AddStdntToClassBtn.Location = new System.Drawing.Point(159, 393);
            this.AddStdntToClassBtn.Name = "AddStdntToClassBtn";
            this.AddStdntToClassBtn.Size = new System.Drawing.Size(75, 23);
            this.AddStdntToClassBtn.TabIndex = 3;
            this.AddStdntToClassBtn.Text = "Add Student";
            this.AddStdntToClassBtn.UseVisualStyleBackColor = true;
            this.AddStdntToClassBtn.Click += new System.EventHandler(this.AddStdntToClassBtn_Click);
            // 
            // CreateClassPanel
            // 
            this.CreateClassPanel.Controls.Add(this.CreateClassBtn);
            this.CreateClassPanel.Controls.Add(this.label3);
            this.CreateClassPanel.Location = new System.Drawing.Point(12, 12);
            this.CreateClassPanel.Name = "CreateClassPanel";
            this.CreateClassPanel.Size = new System.Drawing.Size(441, 213);
            this.CreateClassPanel.TabIndex = 4;
            // 
            // CreateClassBtn
            // 
            this.CreateClassBtn.Location = new System.Drawing.Point(6, 66);
            this.CreateClassBtn.Name = "CreateClassBtn";
            this.CreateClassBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateClassBtn.TabIndex = 4;
            this.CreateClassBtn.Text = "Create Class";
            this.CreateClassBtn.UseVisualStyleBackColor = true;
            this.CreateClassBtn.Click += new System.EventHandler(this.CreateClassBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "To start, you need to create a class before you are able to add students to it. \r" +
    "\n\r\nYou can do so by pressing the button below.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Create_Class_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 561);
            this.Controls.Add(this.CreateClassPanel);
            this.Controls.Add(this.AddStdntPanel);
            this.Name = "Create_Class_Menu";
            this.Text = "Create Class Menu";
            this.Shown += new System.EventHandler(this.Create_Class_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsToAddGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.AddStdntPanel.ResumeLayout(false);
            this.AddStdntPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumeric)).EndInit();
            this.CreateClassPanel.ResumeLayout(false);
            this.CreateClassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsToAddGrid;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AddStdntPanel;
        private System.Windows.Forms.Button AddStdntToClassBtn;
        private System.Windows.Forms.Panel CreateClassPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateClassBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchStdntsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IDNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIDColumn;
    }
}