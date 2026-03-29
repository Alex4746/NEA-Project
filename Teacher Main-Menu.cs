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
    public partial class Teacher_Main_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Teacher_Main_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository(); 
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Closed += (s, args) => Close();
            Globals.User = null;
            logInForm.Show();
        }

        private void Teacher_Main_Menu_Load(object sender, EventArgs e)
        {
            TeacherNameLbl.Text = $"{Globals.User.FirstName} {Globals.User.LastName}!";
        }

        private void classManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Class_Managment_Menu ClassManagementMenu = new Class_Managment_Menu();
            ClassManagementMenu.Closed += (s, args) => Close();
            ClassManagementMenu.Show();
        }

        private void assignHomeworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Assign_Homework_Menu AssignHomeworkMenu = new Assign_Homework_Menu();
            AssignHomeworkMenu.Closed += (s, args) => Close();
            AssignHomeworkMenu.Show();
        }

        private void progressReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Progress_Review_Menu progressReviewMenu = new Progress_Review_Menu();
            progressReviewMenu.Closed += (s, args) => Close();
            progressReviewMenu.Show();
        }

        private void createQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Create_Question_Form createQuestionForm = new Create_Question_Form();
            createQuestionForm.Closed += (s, args) => Close();
            createQuestionForm.Show();
        }
    }
}
