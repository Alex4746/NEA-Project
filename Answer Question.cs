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
using NEA_Math_Program.View;

namespace NEA_Math_Program
{
    public partial class Answer_Question : Form
    {
        private readonly UserRepository _userRepository;
        private int timeStarted;
        int questionNum = 0;
        int numCorrect = 0;
        int totalTimeTaken = 0;
     
        public Answer_Question()
        {
            InitializeComponent();
            _userRepository = new UserRepository();

        }

        private void Answer_Question_Shown(object sender, EventArgs e)
        {
            try
            {
                timeStarted = DateTime.Now.Second;
                if (!Globals.PracticeQuestion)
                {
                    LoadAssignmentQuestion(questionNum);
                }
                else
                {
                    LoadQuestion();
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading question", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Answer_Question_Load(object sender, EventArgs e)
        {
            
        }

        private void SubmitAnswerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool correct;
                int timeTaken = DateTime.Now.Second - timeStarted;
                totalTimeTaken += timeTaken;
                string correctAnswer = _userRepository.GetQuestionAnswer(Globals.Question.QuestionID);
                if (string.IsNullOrWhiteSpace(AnswerTxtBox.Text))
                {
                    MessageBox.Show("Please enter an answer before submitting.", "No Answer Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (AnswerTxtBox.Text.Trim() == correctAnswer.Trim())
                {
                    correct = true;
                    numCorrect++;
                }
                else
                {
                    correct = false;
                }
                if (!Globals.PracticeQuestion)
                {
                    _userRepository.SubmitAnswer(Globals.Assignment.AssignmentID, Globals.Student.StudentID, Globals.Question.QuestionID, timeTaken, correct, AnswerTxtBox.Text);
                    questionNum++;
                    LoadAssignmentQuestion(questionNum);
                }
                else
                {
                    if (correct == true)
                    {
                        MessageBox.Show($"Correct! The answer was {correctAnswer}. It took you {timeTaken} seconds. You will now be taken back", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        Practice_Menu practiceMenu = new Practice_Menu();
                        practiceMenu.Closed += (s, args) => Close();
                        practiceMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Not quite. The correct answer was {correctAnswer}. You will now be taken back", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        Practice_Menu practiceMenu = new Practice_Menu();
                        practiceMenu.Closed += (s, args) => Close();
                        practiceMenu.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error submitting answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadAssignmentQuestion(int questionNum)
        {
            timeStarted = DateTime.Now.Second;
            var questions = _userRepository.GetAssignmentQuestions(Globals.Assignment.AssignmentID);
            if (questions.Count > 0)
            {
                if (questionNum >= questions.Count)
                {
                    _userRepository.AssignmentCompleted(Globals.Assignment.AssignmentID, Globals.Student.StudentID, (int)Math.Round((double)numCorrect / questions.Count * 100), totalTimeTaken);
                    MessageBox.Show("You have completed the assignment! You will now be transferred to a menu where you can see how you did", "Assignment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Statistics_Menu statisticsMenu = new Statistics_Menu();
                    statisticsMenu.Closed += (s, args) => Close();
                    statisticsMenu.Show();
                }
                else
                {
                    var question = questions[questionNum];
                    Globals.Question = new QuestionViewModel()
                    {
                        QuestionID = question.QuestionID,
                        Question = question.Question,
                        Answer = question.Answer,
                        Difficulty = question.Difficulty
                    };
                    QuestionLbl.Text = $"{Globals.Question.Question}";
                    QuestionsLeftLbl.Text = $"Question {questionNum + 1}  of {questions.Count}";
                }
            }
        }
        private void LoadQuestion()
        {
            timeStarted = DateTime.Now.Second;
            var question = _userRepository.GetQuestion(Globals.Question.QuestionID);
            Globals.Question.Question = question.Question;
            Globals.Question.Answer = question.Answer;
            QuestionLbl.Text = $"{Globals.Question.Question}";
            QuestionsLeftLbl.Text = $"Question 1 of 1";
        }
    }  
}
