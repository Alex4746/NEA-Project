namespace NEA_Math_Program
{
    partial class LogInForm
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
            this.LogInLabel = new System.Windows.Forms.Label();
            this.EnterInfoLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EnterPLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.STLabel = new System.Windows.Forms.Label();
            this.TeacherButton = new System.Windows.Forms.RadioButton();
            this.StudentButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccLink = new System.Windows.Forms.LinkLabel();
            this.SubmitLogInButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInLabel
            // 
            this.LogInLabel.BackColor = System.Drawing.SystemColors.Control;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.Location = new System.Drawing.Point(14, 17);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(99, 41);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "Log-In";
            // 
            // EnterInfoLabel
            // 
            this.EnterInfoLabel.AutoSize = true;
            this.EnterInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterInfoLabel.Location = new System.Drawing.Point(17, 58);
            this.EnterInfoLabel.Name = "EnterInfoLabel";
            this.EnterInfoLabel.Size = new System.Drawing.Size(209, 16);
            this.EnterInfoLabel.TabIndex = 1;
            this.EnterInfoLabel.Text = "Please enter your E-Mail address:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(20, 77);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(379, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // EnterPLabel
            // 
            this.EnterPLabel.AutoSize = true;
            this.EnterPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPLabel.Location = new System.Drawing.Point(17, 136);
            this.EnterPLabel.Name = "EnterPLabel";
            this.EnterPLabel.Size = new System.Drawing.Size(177, 16);
            this.EnterPLabel.TabIndex = 3;
            this.EnterPLabel.Text = "Please enter your password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(20, 155);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(379, 20);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // STLabel
            // 
            this.STLabel.AutoSize = true;
            this.STLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STLabel.Location = new System.Drawing.Point(455, 58);
            this.STLabel.Name = "STLabel";
            this.STLabel.Size = new System.Drawing.Size(199, 16);
            this.STLabel.TabIndex = 5;
            this.STLabel.Text = "Are you a Teacher or a Student?";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Don\'t have an account yet?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CreateAccLink
            // 
            this.CreateAccLink.AutoSize = true;
            this.CreateAccLink.Location = new System.Drawing.Point(17, 310);
            this.CreateAccLink.Name = "CreateAccLink";
            this.CreateAccLink.Size = new System.Drawing.Size(54, 13);
            this.CreateAccLink.TabIndex = 11;
            this.CreateAccLink.TabStop = true;
            this.CreateAccLink.Text = "Click here";
            this.CreateAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccLink_LinkClicked);
            // 
            // SubmitLogInButton
            // 
            this.SubmitLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitLogInButton.Location = new System.Drawing.Point(20, 181);
            this.SubmitLogInButton.Name = "SubmitLogInButton";
            this.SubmitLogInButton.Size = new System.Drawing.Size(112, 38);
            this.SubmitLogInButton.TabIndex = 12;
            this.SubmitLogInButton.Text = "Submit";
            this.SubmitLogInButton.UseVisualStyleBackColor = true;
            this.SubmitLogInButton.Click += new System.EventHandler(this.SubmitLogInButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentButton);
            this.groupBox1.Controls.Add(this.TeacherButton);
            this.groupBox1.Location = new System.Drawing.Point(458, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(68, 53);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubmitLogInButton);
            this.Controls.Add(this.CreateAccLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EnterPLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EnterInfoLabel);
            this.Controls.Add(this.LogInLabel);
            this.Name = "LogInForm";
            this.Text = "Log-In Form";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label EnterInfoLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EnterPLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label STLabel;
        private System.Windows.Forms.RadioButton TeacherButton;
        private System.Windows.Forms.RadioButton StudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel CreateAccLink;
        private System.Windows.Forms.Button SubmitLogInButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

