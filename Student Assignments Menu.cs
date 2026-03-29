using NEA_Math_Program.Controller;
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
    public partial class Student_Assignments_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Student_Assignments_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void Student_Assignments_Menu_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadAssignments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading assignments", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAssignments()
        {
            try
            {
                AssignmentGrid.BeginInvoke(new Action(() =>
                {
                    var assignment = _userRepository.GetStudentAssignments(Globals.Student.StudentID);
                    AssignmentGrid.AutoGenerateColumns = false;
                    AssignmentGrid.DataSource = assignment;
                    AssignmentGrid.Refresh();
                    AssignmentGrid.ClearSelection();
                }));
                StudentNameLbl.Text = $"These are the assignments for {Globals.Student.FirstName} {Globals.Student.LastName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading assignments", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewAssignmentBtn_Click(object sender, EventArgs e)
        {
            Globals.Assignment = new View.AssignmentViewModel()
            {
                AssignmentID = (int)AssignmentGrid.CurrentRow.Cells["AssignmentIDCol"].Value,
                Title = AssignmentGrid.CurrentRow.Cells["AssignmentTitleCol"].Value.ToString(),
                Content = AssignmentGrid.CurrentRow.Cells["AssignmentContentCol"].Value.ToString(),
            };
            Hide();
            Student_Question_Results studentQuestionMenu = new Student_Question_Results();
            studentQuestionMenu.Closed += (s, args) => Close();
            studentQuestionMenu.Show();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Progress_Review_Menu progressMenu = new Progress_Review_Menu();
            progressMenu.Closed += (s, args) => Close();
            progressMenu.Show();
        }
    }
}
