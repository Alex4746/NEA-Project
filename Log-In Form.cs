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
    public partial class LogInForm : Form
    {
        private readonly UserRepository _userRepository;
        public LogInForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SubmitLogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    MessageBox.Show("Please fill all the fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UserType();
                var user = _userRepository.GetUserByEmail(EmailTextBox.Text, Globals.User.IsStudent);
                if (user != null)
                {
                    if (user.Password.Equals(PasswordTextBox.Text))
                    {
                        Globals.User.FirstName = user.FirstName;
                        Globals.User.LastName = user.LastName;
                        Globals.User.Email = user.Email;
                        Globals.User.ID = user.ID;

                        Hide();
                        if (Globals.User.IsStudent)
                        {
                            Globals.Student = new View.StudentViewModel()
                            {
                                StudentID = user.ID,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Email = user.Email
                            };
                            var student = new Student_Main_Menu();
                            student.Closed += (s, args) => Close();
                            student.Show();
                        }
                        else
                        {
                            Globals.Teacher = new View.TeacherViewModel()
                            {
                                TeacherID = user.ID,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Email = user.Email
                            };
                            var teacher = new Teacher_Main_Menu();
                            teacher.Closed += (s, args) => Close();
                            teacher.Show();
                        }
                        return;
                    }
                }
                MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UserType()
        {
            if (TeacherButton.Checked)
            {
                Globals.User = new View.UserView()
                {
                    IsStudent = false
                };
                
            }
            else if (StudentButton.Checked)
            {
                Globals.User = new View.UserView()
                {
                    IsStudent = true
                };
                Globals.Student = new View.StudentViewModel();
            }
            else
            {
                throw new InvalidOperationException("Please select a user type.");
            }
        }

        private void CreateAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Create_Account_Form createAccountForm = new Create_Account_Form();
            createAccountForm.Closed += (s, args) => Close();
            createAccountForm.Show();
        }
    }
}
