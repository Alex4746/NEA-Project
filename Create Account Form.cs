using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEA_Math_Program.Controller;

namespace NEA_Math_Program
{
    public partial class Create_Account_Form : Form
    {
        private readonly UserRepository _userRepository;
        public Create_Account_Form()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(FirstNameTxtBox.Text) || string.IsNullOrEmpty(LastNameTxtBox.Text) ||
                    string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Please fill all the fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool isStudent;
                if (StudentButton.Checked)
                {
                    isStudent = true;
                }
                else if (TeacherButton.Checked)
                {
                    isStudent = false;
                }
                else
                {
                    MessageBox.Show("Please select a user type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string firstName = FirstNameTxtBox.Text;
                string lastName = LastNameTxtBox.Text;
                string email = EmailTextBox.Text;
                string password = PasswordTextBox.Text;
                _userRepository.CreateUser(isStudent, firstName, lastName, email, password);
                MessageBox.Show("Account created successfully! You will now be taken back to the log-in screen", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                LogInForm logInForm = new LogInForm();
                logInForm.Closed += (s, args) => Close();
                logInForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
