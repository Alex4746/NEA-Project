using NEA_Math_Program.Controller;
using NEA_Math_Program.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Math_Program
{
    public partial class Progress_Review_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Progress_Review_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void LoadStudents()
        {
            int classID = _userRepository.GetClassID(Globals.Teacher.TeacherID);
            StudentGrid.BeginInvoke(new Action(() =>
            {
                int idFilter = 0;
                string nameFilter = " ";
                var students = _userRepository.GetStudents(classID, idFilter, nameFilter);
                StudentGrid.AutoGenerateColumns = false;
                StudentGrid.DataSource = students;
                StudentGrid.Refresh();
                StudentGrid.ClearSelection();
            }));
        }

        private void Progress_Review_Menu_Shown(object sender, EventArgs e)
        {
            if (_userRepository.HasClass(Globals.Teacher.Email))
            {
                LoadStudents();
            }
            else
            {
                MessageBox.Show("You do not have a class. Please make one now.", "No Classes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Create_Class_Menu createClassMenu = new Create_Class_Menu();
                createClassMenu.Closed += (s, args) => Close();
                createClassMenu.Show();
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher_Main_Menu teacherMainMenu = new Teacher_Main_Menu();
            teacherMainMenu.Closed += (s, args) => Close();
            teacherMainMenu.Show();
        }

        private void ViewAssignmentsBtn_Click(object sender, EventArgs e)
        {
            Globals.Student = new View.StudentViewModel()
            {
                StudentID = (int)StudentGrid.CurrentRow.Cells["StudentIDColumn"].Value,
                FirstName = StudentGrid.CurrentRow.Cells["FirstNameColumn"].Value.ToString(),
                LastName = StudentGrid.CurrentRow.Cells["LastNameColumn"].Value.ToString(),
            };
            Hide();
            Student_Assignments_Menu studentAssignmentsMenu = new Student_Assignments_Menu();
            studentAssignmentsMenu.Closed += (s, args) => Close();
            studentAssignmentsMenu.Show();
        }
    }
}
