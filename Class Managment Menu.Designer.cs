namespace NEA_Math_Program
{
    partial class Class_Managment_Menu
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
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new NEA_Math_Program.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassNameLbl = new System.Windows.Forms.Label();
            this.NumOfStudentsLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchStdntsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.RemoveStudentBtn = new System.Windows.Forms.Button();
            this.IDToRemoveNumeric = new System.Windows.Forms.NumericUpDown();
            this.BacktoMainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDToRemoveNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGrid
            // 
            this.StudentGrid.AutoGenerateColumns = false;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.StudentIDColumn,
            this.EmailColumn});
            this.StudentGrid.DataSource = this.database1DataSetBindingSource;
            this.StudentGrid.Location = new System.Drawing.Point(12, 99);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(600, 321);
            this.StudentGrid.TabIndex = 0;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here is your class:";
            // 
            // ClassNameLbl
            // 
            this.ClassNameLbl.AutoSize = true;
            this.ClassNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLbl.Location = new System.Drawing.Point(9, 35);
            this.ClassNameLbl.Name = "ClassNameLbl";
            this.ClassNameLbl.Size = new System.Drawing.Size(76, 16);
            this.ClassNameLbl.TabIndex = 2;
            this.ClassNameLbl.Text = "class name";
            // 
            // NumOfStudentsLbl
            // 
            this.NumOfStudentsLbl.AutoSize = true;
            this.NumOfStudentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfStudentsLbl.Location = new System.Drawing.Point(9, 64);
            this.NumOfStudentsLbl.Name = "NumOfStudentsLbl";
            this.NumOfStudentsLbl.Size = new System.Drawing.Size(99, 16);
            this.NumOfStudentsLbl.TabIndex = 3;
            this.NumOfStudentsLbl.Text = "num of students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "You can search by:";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(754, 64);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(118, 20);
            this.LastNameTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // IDNumeric
            // 
            this.IDNumeric.Location = new System.Drawing.Point(754, 99);
            this.IDNumeric.Name = "IDNumeric";
            this.IDNumeric.Size = new System.Drawing.Size(120, 20);
            this.IDNumeric.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // SearchStdntsBtn
            // 
            this.SearchStdntsBtn.Location = new System.Drawing.Point(799, 134);
            this.SearchStdntsBtn.Name = "SearchStdntsBtn";
            this.SearchStdntsBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchStdntsBtn.TabIndex = 15;
            this.SearchStdntsBtn.Text = "Search";
            this.SearchStdntsBtn.UseVisualStyleBackColor = true;
            this.SearchStdntsBtn.Click += new System.EventHandler(this.SearchStdntsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "If you want add or remove a student, type their ID into the box below \r\nand click" +
    " the respective button:";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(618, 310);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.AddStudentBtn.TabIndex = 17;
            this.AddStudentBtn.Text = "Add Student";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // RemoveStudentBtn
            // 
            this.RemoveStudentBtn.Location = new System.Drawing.Point(618, 339);
            this.RemoveStudentBtn.Name = "RemoveStudentBtn";
            this.RemoveStudentBtn.Size = new System.Drawing.Size(96, 23);
            this.RemoveStudentBtn.TabIndex = 18;
            this.RemoveStudentBtn.Text = "Remove Student";
            this.RemoveStudentBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentBtn.Click += new System.EventHandler(this.RemoveStudentBtn_Click);
            // 
            // IDToRemoveNumeric
            // 
            this.IDToRemoveNumeric.Location = new System.Drawing.Point(618, 284);
            this.IDToRemoveNumeric.Name = "IDToRemoveNumeric";
            this.IDToRemoveNumeric.Size = new System.Drawing.Size(120, 20);
            this.IDToRemoveNumeric.TabIndex = 19;
            // 
            // BacktoMainMenuBtn
            // 
            this.BacktoMainMenuBtn.Location = new System.Drawing.Point(1097, 397);
            this.BacktoMainMenuBtn.Name = "BacktoMainMenuBtn";
            this.BacktoMainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.BacktoMainMenuBtn.TabIndex = 20;
            this.BacktoMainMenuBtn.Text = "Main-Menu";
            this.BacktoMainMenuBtn.UseVisualStyleBackColor = true;
            this.BacktoMainMenuBtn.Click += new System.EventHandler(this.BacktoMainMenuBtn_Click);
            // 
            // Class_Managment_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.BacktoMainMenuBtn);
            this.Controls.Add(this.IDToRemoveNumeric);
            this.Controls.Add(this.RemoveStudentBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchStdntsBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumOfStudentsLbl);
            this.Controls.Add(this.ClassNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentGrid);
            this.Name = "Class_Managment_Menu";
            this.Text = "Class Managment Menu";
            this.Load += new System.EventHandler(this.Class_Managment_Menu_Load);
            this.Shown += new System.EventHandler(this.Class_Managment_Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDToRemoveNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClassNameLbl;
        private System.Windows.Forms.Label NumOfStudentsLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IDNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchStdntsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button RemoveStudentBtn;
        private System.Windows.Forms.NumericUpDown IDToRemoveNumeric;
        private System.Windows.Forms.Button BacktoMainMenuBtn;
    }
}