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
    public partial class Create_Question_Form : Form
    {
        private readonly UserRepository _userRepository;
        public Create_Question_Form()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void BacktoMainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher_Main_Menu teacherMainMenu = new Teacher_Main_Menu();
            teacherMainMenu.Closed += (s, args) => Close();
            teacherMainMenu.Show();
        }

        private void SubmitQuestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(QuestionTxtBox.Text) || string.IsNullOrEmpty(AnswerTxtBox.Text) || string.IsNullOrEmpty(DescriptionTxtBox.Text))
                {
                    MessageBox.Show("Please fill all the fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DifficultyNumeric.Value < 1 || DifficultyNumeric.Value > 3)
                {
                    MessageBox.Show("Difficulty must be between 1 and 3.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string question = QuestionTxtBox.Text;
                string answer = AnswerTxtBox.Text;
                string description = DescriptionTxtBox.Text;
                int difficulty = (int)DifficultyNumeric.Value;
                _userRepository.CreateQuestion(question, answer, difficulty, description);
                MessageBox.Show("Question created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating question", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
