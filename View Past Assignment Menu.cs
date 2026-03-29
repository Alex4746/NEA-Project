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
    public partial class View_Past_Assignment_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public View_Past_Assignment_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Statistics_Menu statisticsMenu = new Statistics_Menu();
            statisticsMenu.Closed += (s, args) => Close();
            statisticsMenu.Show();
        }

        private void View_Past_Assignment_Menu_Shown(object sender, EventArgs e)
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
        private void ViewQuestionBtn_Click(object sender, EventArgs e)
        {
            LoadQuestionResults();
        }
    }
}
