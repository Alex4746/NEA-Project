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
    public partial class Student_Main_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Student_Main_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void Student_Main_Menu_Load(object sender, EventArgs e)
        {
            StudentNameLbl.Text = $"{Globals.User.FirstName} {Globals.User.LastName}!";
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Closed += (s, args) => Close();
            Globals.User = null;
            logInForm.Show();
        }

        private void classManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Homework_Assignment_Menu homeworkAssignment = new Homework_Assignment_Menu();
            homeworkAssignment.Closed += (s, args) => Close();
            homeworkAssignment.Show();
        }

        private void progressReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Statistics_Menu statistics_Menu = new Statistics_Menu();
            statistics_Menu.Closed += (s, args) => Close();
            statistics_Menu.Show();
        }

        private void assignHomeworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Practice_Menu practiceMenu = new Practice_Menu();
            practiceMenu.Closed += (s, args) => Close();
            practiceMenu.Show();
        }
    }
}
