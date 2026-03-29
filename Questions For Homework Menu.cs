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
    public partial class Questions_For_Homework_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Questions_For_Homework_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void CreateAssignmentBtn_Click(object sender, EventArgs e)
        {

        }

        private void Questions_For_Homework_Menu_Shown(object sender, EventArgs e)
        {
            LoadQuestions();
            LoadAssignmentQuestions(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID));
        }
        private void LoadQuestions()
        {
            try
            {
                QuestionsGrid.BeginInvoke(new Action(() =>
                {

                    var questions = _userRepository.GetQuestions();
                    QuestionsGrid.AutoGenerateColumns = false;
                    QuestionsGrid.DataSource = questions;
                    QuestionsGrid.Refresh();
                    QuestionsGrid.ClearSelection();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error loading assignment questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddQuestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
            if (QuestionsGrid.CurrentRow == null)
                {
                    MessageBox.Show("Please select a question to add.", "No Question Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int questionID = (int)QuestionsGrid.CurrentRow.Cells["QuestionIDCol"].Value;
                _userRepository.AddQuestionToAssignment(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID), questionID);
                MessageBox.Show("Question added to assignment.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAssignmentQuestions(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding question to assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Assign_Homework_Menu AssignHomeworkMenu = new Assign_Homework_Menu();
            AssignHomeworkMenu.Closed += (s, args) => Close();
            AssignHomeworkMenu.Show();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher_Main_Menu teacherMainMenu = new Teacher_Main_Menu();
            teacherMainMenu.Closed += (s, args) => Close();
            teacherMainMenu.Show();
        }

        private void RemoveQuestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuestionsGrid.CurrentRow == null)
                {
                    MessageBox.Show("Please select a question to remove.", "No Question Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int questionID = (int)QuestionsGrid.CurrentRow.Cells["AssignedQuestionIDCol"].Value;
                _userRepository.RemoveQuestionFromAssignment(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID), questionID);
                MessageBox.Show("Question removed from assignment.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAssignmentQuestions(_userRepository.GetAssignmentID(Globals.Teacher.TeacherID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error removing question from assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
