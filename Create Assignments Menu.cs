using NEA_Math_Program.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Math_Program
{
    public partial class Create_Assignments_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Create_Assignments_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string title = AssignmentTitleTxtBox.Text?.Trim();
                string content = AssignmentContentTxtBox.Text?.Trim();
                DateTime dueDate = dateTimePicker.Value;

                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Please enter an assignment title.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _userRepository.CreateAssignment(title, content, dueDate, Globals.Teacher.TeacherID);

                MessageBox.Show("Assignment Created", "Assignment created successfully, you will be transferred to another menu where you can add the questions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Questions_For_Homework_Menu questionsForHomework = new Questions_For_Homework_Menu();
                questionsForHomework.Closed += (s, args) => Close();
                questionsForHomework.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
