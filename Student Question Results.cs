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
    public partial class Student_Question_Results : Form
    {
        private readonly UserRepository _userRepository;
        public Student_Question_Results()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void LoadAssignmentQuestions()
        {
            try
            {
                AssignmentQuestionsGrid.BeginInvoke(new Action(() =>
                {
                    var questions = _userRepository.GetAssignmentQuestions(Globals.Assignment.AssignmentID);
                    AssignmentQuestionsGrid.AutoGenerateColumns = false;
                    AssignmentQuestionsGrid.DataSource = questions;
                    AssignmentQuestionsGrid.Refresh();
                    AssignmentQuestionsGrid.ClearSelection();
                }));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAssignmentResults()
        {
            var results = _userRepository.GetAssignmentResults(Globals.Assignment.AssignmentID, Globals.Student.StudentID);
            Globals.AssignmentResults = new View.AssignmentResultViewModel()
            {
                Status = results.Status,
                Result = results.Result,
                TimeTaken = results.TimeTaken,
                Feedback = results.Feedback
            };
            AssignmentTitleLbl.Text = Globals.Assignment.Title;
            AssignmentDescLbl.Text = Globals.Assignment.Content;
            statusLbl.Text = $"{Globals.AssignmentResults.Status}";
            ResultLbl.Text = $"{Globals.AssignmentResults.Result}";
            TimeTakenLbl.Text = $"{Globals.AssignmentResults.TimeTaken / 60} minutes";
            if (Globals.AssignmentResults.Feedback != null)
            {
                FeedbackLbl.Text = $"{Globals.AssignmentResults.Feedback}";
            }
            else
            {
                FeedbackLbl.Text = "No feedback provided yet.";
            }

        }
        private void LoadQuestionResults()
        {
            var questions = _userRepository.GetQuestionResults(Globals.Assignment.AssignmentID, Globals.Student.StudentID, (int)AssignmentQuestionsGrid.CurrentRow.Cells["AssignedQuestionIDCol"].Value);
            CorrectLbl.Text = questions.IsCorrect ? "Correct" : "Incorrect";
            ResponseLbl.Text = $"{questions.Response}";
            CorrectAnswerLbl.Text = $"{questions.CorrectAnswer}";
            TimeTakenForQLbl.Text = $"{questions.TimeTakenSeconds} seconds";
        }

        private void Student_Question_Results_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadAssignmentQuestions();
                LoadAssignmentResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Student_Assignments_Menu studentAssignments = new Student_Assignments_Menu();
            studentAssignments.Closed += (s, args) => Close();
            studentAssignments.Show();
        }

        private void ViewQuestionBtn_Click(object sender, EventArgs e)
        {
            LoadQuestionResults();
        }

        private void SubmitFeedbackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int assignmentID = Globals.Assignment.AssignmentID;
                int studentID = Globals.Student.StudentID;
                if (string.IsNullOrWhiteSpace(FeedbackTxtBox.Text))
                {
                    MessageBox.Show("Please enter feedback before submitting.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_userRepository.HasFeedback(assignmentID, studentID))
                {
                    MessageBox.Show("You have already given feedback for this student's assignment.", "Feedback already submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _userRepository.SubmitFeedback(assignmentID, studentID, FeedbackTxtBox.Text);
                LoadAssignmentResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error submitting feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
