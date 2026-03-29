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
    public partial class Assign_Homework_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Assign_Homework_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void Assign_Homework_Menu_Load(object sender, EventArgs e)
        {

        }

        private void CreateAssignmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int assignmentID = _userRepository.GetAssignmentID(Globals.Teacher.TeacherID);
                if (assignmentID == 0)
                {
                    // No existing assignment — allow creating a new one
                    Hide();
                    Create_Assignments_Menu createAssignmentsMenu = new Create_Assignments_Menu();
                    createAssignmentsMenu.Closed += (s, args) => Close();
                    createAssignmentsMenu.Show();
                    return;
                }
                else
                {
                    if (_userRepository.AssignmentCreated(assignmentID, Globals.Teacher.TeacherID))
                    {
                        if (_userRepository.IsHomeworkAssigned(assignmentID))
                        {
                            // Old assignment is already assigned — allow creating a new one
                            Hide();
                            Create_Assignments_Menu createAssignmentsMenu = new Create_Assignments_Menu();
                            createAssignmentsMenu.Closed += (s, args) => Close();
                            createAssignmentsMenu.Show();
                        }
                        else
                        {
                            // Old assignment exists but hasn't been assigned yet
                            MessageBox.Show("You have an unassigned assignment. Please assign or delete it first.", "Assignment Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudents()
        {
            int classID = _userRepository.GetClassID(Globals.Teacher.TeacherID);

            StudentGrid.BeginInvoke(new Action(() =>
            {

                var students = _userRepository.GetStudents(classID, 1, "A");
                StudentGrid.AutoGenerateColumns = false;
                StudentGrid.DataSource = students;
                StudentGrid.Refresh();
                StudentGrid.ClearSelection();
            }));
        }
        private void LoadAssignmentQuestions(int assignmentID)
        {
            try
            {
                AssignmentGrid.BeginInvoke(new Action(() =>
                {
                    var questions = _userRepository.GetAssignmentQuestions(assignmentID);
                    AssignmentGrid.AutoGenerateColumns = false;
                    AssignmentGrid.DataSource = questions;
                    AssignmentGrid.Refresh();
                    AssignmentGrid.ClearSelection();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Assign_Homework_Menu_Shown(object sender, EventArgs e)
        {
            if (_userRepository.HasClass(Globals.Teacher.Email))
            {
                LoadStudents();
                LoadAssignmentQuestions(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID));
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ManageAssignmentBtn_Click(object sender, EventArgs e)
        {
            if (_userRepository.IsHomeworkAssigned(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID)))
            {
                MessageBox.Show("You have already assigned this homework and can no longer make changes to it. Please create a new assignment.", "Homework Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Hide();
                Questions_For_Homework_Menu questionsForHomework = new Questions_For_Homework_Menu();
                questionsForHomework.Closed += (s, args) => Close();
                questionsForHomework.Show();
            }  
        }

        private void AssignHmwrkClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < StudentGrid.Rows.Count; i++)
                {
                    if (StudentGrid.Rows[i].Cells[0].Value != null)
                    {
                        int studentID = Convert.ToInt32(StudentGrid.Rows[i].Cells["StudentIDColumn"].Value);
                        int assignmentID = _userRepository.GetAssignmentID(Globals.Teacher.TeacherID);
                        if (_userRepository.IsHomeworkAssigned(studentID, assignmentID))
                        {
                            continue; 
                        }
                        _userRepository.AssignHomeworkToStudent(assignmentID, studentID);
                    }
                }
                MessageBox.Show("Homework assigned to class.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error assigning homework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssignHmwrkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = (int)StudentGrid.CurrentRow.Cells["StudentIDColumn"].Value; ;
                int assignmentID = _userRepository.GetAssignmentID(Globals.Teacher.TeacherID);
                if (_userRepository.IsHomeworkAssigned(studentID, assignmentID))
                {
                    MessageBox.Show("Homework is already assigned to this student.", "Already Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _userRepository.AssignHomeworkToStudent(assignmentID, studentID);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error assigning homework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher_Main_Menu teacherMainMenu = new Teacher_Main_Menu();
            teacherMainMenu.Closed += (s, args) => Close();
            teacherMainMenu.Show();
        }
    }
}
