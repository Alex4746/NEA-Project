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
    public partial class Homework_Assignment_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Homework_Assignment_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void Homework_Assignment_Menu_Shown(object sender, EventArgs e)
        {
            try
            {
                int teacherID = _userRepository.GetTeacherID(Globals.Student.StudentID);
                var assignment = _userRepository.GetAssignmentDetails(teacherID);
                Globals.Assignment = new View.AssignmentViewModel()
                {
                    AssignmentID = assignment.AssignmentID,
                    Title = assignment.Title,
                    Content = assignment.Content,
                    DueDate = assignment.DueDate
                };
                
                LoadAssignmentQuestions(assignment.AssignmentID);
                AssignmentTitleLbl.Text = assignment.Title.ToString();
                AssignmentDescLbl.Text = assignment.Content;
                AssignmentDueDatePicker.Value = assignment.DueDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading assignment details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void StartAssignmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userRepository.CompletedHomework(Globals.Assignment.AssignmentID, Globals.Student.StudentID))
                {
                    MessageBox.Show("You have already completed this assignment and are unable to do it again.", "Assignment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StartAssignmentBtn.Enabled = false;
                    return;
                }
                else
                {
                    Hide();
                    Answer_Question answerQuestionMenu = new Answer_Question();
                    answerQuestionMenu.Closed += (s, args) => Close();
                    answerQuestionMenu.Show();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error starting assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Student_Main_Menu studentMainMenu = new Student_Main_Menu();
            studentMainMenu.Closed += (s, args) => Close();
            studentMainMenu.Show();
        }
    }
}
