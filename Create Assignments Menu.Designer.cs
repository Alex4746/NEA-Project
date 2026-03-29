namespace NEA_Math_Program
{
    partial class Create_Assignments_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AssignmentTitleTxtBox = new System.Windows.Forms.TextBox();
            this.AssignmentContentTxtBox = new System.Windows.Forms.TextBox();
            this.AssignmentDueDateTxtBox = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the details requested using the text boxes below so that your assign" +
    "ment can be created.\r\nThe title of the assignment is required while the rest are" +
    " optional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title of Assignment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description of Assignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due Date for Assignment";
            // 
            // AssignmentTitleTxtBox
            // 
            this.AssignmentTitleTxtBox.Location = new System.Drawing.Point(206, 105);
            this.AssignmentTitleTxtBox.Name = "AssignmentTitleTxtBox";
            this.AssignmentTitleTxtBox.Size = new System.Drawing.Size(93, 20);
            this.AssignmentTitleTxtBox.TabIndex = 4;
            // 
            // AssignmentContentTxtBox
            // 
            this.AssignmentContentTxtBox.Location = new System.Drawing.Point(331, 105);
            this.AssignmentContentTxtBox.Name = "AssignmentContentTxtBox";
            this.AssignmentContentTxtBox.Size = new System.Drawing.Size(126, 20);
            this.AssignmentContentTxtBox.TabIndex = 5;
            // 
            // AssignmentDueDateTxtBox
            // 
            this.AssignmentDueDateTxtBox.Location = new System.Drawing.Point(488, 171);
            this.AssignmentDueDateTxtBox.Name = "AssignmentDueDateTxtBox";
            this.AssignmentDueDateTxtBox.Size = new System.Drawing.Size(122, 20);
            this.AssignmentDueDateTxtBox.TabIndex = 6;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(15, 131);
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
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please use the \"dd/mm/yyyy\" format when entering a Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Please note that you will not be able to change these details after you have subm" +
    "itted them.";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(488, 105);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // Create_Assignments_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.AssignmentDueDateTxtBox);
            this.Controls.Add(this.AssignmentContentTxtBox);
            this.Controls.Add(this.AssignmentTitleTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_Assignments_Menu";
            this.Text = "Create Assignments Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AssignmentTitleTxtBox;
        private System.Windows.Forms.TextBox AssignmentContentTxtBox;
        private System.Windows.Forms.TextBox AssignmentDueDateTxtBox;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}