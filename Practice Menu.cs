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
    public partial class Practice_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Practice_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Student_Main_Menu studentMainMenu = new Student_Main_Menu();
            studentMainMenu.Closed += (s, args) => Close();
            studentMainMenu.Show();
        }

        private void Practice_Menu_Shown(object sender, EventArgs e)
        {
            LoadQuestions();
        }
        private void LoadQuestions()
        {
            try
            {
                QuestionsGrid.BeginInvoke(new Action(() =>
                {
                    string keywordFilter = KeywordTxtBox.Text.Trim();
                    int difficultyFilter = (int)DifficultyNumeric.Value;
                    int questionIDFilter = (int)QuestionIDNumeric.Value;
                    var questions = _userRepository.GetQuestions(questionIDFilter, difficultyFilter, keywordFilter);
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

        private void SearchQuestionsBtn_Click(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void SelectQuestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuestionsGrid.CurrentRow == null)
                {
                    MessageBox.Show("Please select a question from the table.", "No Question Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Globals.Question = new View.QuestionViewModel
                {
                    QuestionID = (int)QuestionsGrid.CurrentRow.Cells["QuestionIDCol"].Value
                };
                Globals.PracticeQuestion = true;
                Hide();
                Answer_Question answerQuestionMenu = new Answer_Question();
                answerQuestionMenu.Closed += (s, args) => Close();
                answerQuestionMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading question", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RandomQBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int questionType;
                if (AlgebraicBtn.Checked)
                {
                    questionType = 1;
                }
                else if (ArithmeticBtn.Checked)
                {
                    questionType = 2;
                }
                else
                {
                    MessageBox.Show("Please select a question type.", "No Question Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int difficulty = Convert.ToInt32(RandomQDiffNumeric.Value);
                string expression = Question_Generator.GenerateQuestion(difficulty, questionType);

                // Use the correct solver based on question type
                string answer;
                string displayQuestion;
                if (questionType == 1 && expression.Contains("="))
                {
                    answer = Math.Round(Equation_Solver.SolveAlgebraicEquation(expression), 2).ToString();
                    displayQuestion = "Solve for x: " + expression;
                }
                else
                {
                    answer = Equation_Solver.SolveExpression(expression);
                    displayQuestion = "What is " + expression + "?";
                }

                string description = $"Randomly generated {(questionType == 1 ? "algebraic" : "arithmetic")} question.";

                // Store the display version as the question, raw answer as the answer
                _userRepository.CreateQuestion(0, displayQuestion, answer, difficulty, description);
                Globals.Question = new View.QuestionViewModel
                {
                    QuestionID = 0
                };
                Globals.PracticeQuestion = true;
                Hide();
                Answer_Question answerQuestionMenu = new Answer_Question();
                answerQuestionMenu.Closed += (s, args) => Close();
                answerQuestionMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading question", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
