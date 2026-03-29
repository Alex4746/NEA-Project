namespace NEA_Math_Program
{
    partial class Create_Account_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentButton = new System.Windows.Forms.RadioButton();
            this.TeacherButton = new System.Windows.Forms.RadioButton();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.STLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterPLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EnterInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentButton);
            this.groupBox1.Controls.Add(this.TeacherButton);
            this.groupBox1.Location = new System.Drawing.Point(592, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(68, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // StudentButton
            // 
            this.StudentButton.AutoSize = true;
            this.StudentButton.Location = new System.Drawing.Point(0, 30);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(62, 17);
            this.StudentButton.TabIndex = 7;
            this.StudentButton.TabStop = true;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = true;
            // 
            // TeacherButton
            // 
            this.TeacherButton.AutoSize = true;
            this.TeacherButton.Location = new System.Drawing.Point(0, 7);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(65, 17);
            this.TeacherButton.TabIndex = 6;
            this.TeacherButton.TabStop = true;
            this.TeacherButton.Text = "Teacher";
            this.TeacherButton.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(12, 230);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(112, 38);
            this.RegisterBtn.TabIndex = 19;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // STLabel
            // 
            this.STLabel.AutoSize = true;
            this.STLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STLabel.Location = new System.Drawing.Point(589, 70);
            this.STLabel.Name = "STLabel";
            this.STLabel.Size = new System.Drawing.Size(199, 16);
            this.STLabel.TabIndex = 18;
            this.STLabel.Text = "Are you a Teacher or a Student?";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 204);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(379, 20);
            this.PasswordTextBox.TabIndex = 17;
            // 
            // EnterPLabel
            // 
            this.EnterPLabel.AutoSize = true;
            this.EnterPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPLabel.Location = new System.Drawing.Point(9, 185);
            this.EnterPLabel.Name = "EnterPLabel";
            this.EnterPLabel.Size = new System.Drawing.Size(177, 16);
            this.EnterPLabel.TabIndex = 16;
            this.EnterPLabel.Text = "Please enter your password:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 145);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(379, 20);
            this.EmailTextBox.TabIndex = 15;
            // 
            // EnterInfoLabel
            // 
            this.EnterInfoLabel.AutoSize = true;
            this.EnterInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterInfoLabel.Location = new System.Drawing.Point(9, 126);
            this.EnterInfoLabel.Name = "EnterInfoLabel";
            this.EnterInfoLabel.Size = new System.Drawing.Size(209, 16);
            this.EnterInfoLabel.TabIndex = 14;
            this.EnterInfoLabel.Text = "Please enter your E-Mail address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Create Account";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(15, 89);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(152, 20);
            this.FirstNameTxtBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Please enter your first and last Name:";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(173, 89);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(152, 20);
            this.LastNameTxtBox.TabIndex = 25;
            // 
            // Create_Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.STLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EnterPLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EnterInfoLabel);
            this.Name = "Create_Account_Form";
            this.Text = "Create_Account_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton StudentButton;
        private System.Windows.Forms.RadioButton TeacherButton;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label STLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label EnterPLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EnterInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTxtBox;
    }
}