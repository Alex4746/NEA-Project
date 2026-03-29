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
    public partial class Statistics_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Statistics_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void Statistics_Menu_Shown(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ViewAssignmentBtn_Click(object sender, EventArgs e)
        {
            Globals.Assignment.AssignmentID = (int)AssignmentGrid.CurrentRow.Cells["AssignmentIDCol"].Value;
            Hide();
            View_Past_Assignment_Menu pastAssignmentsMenu = new View_Past_Assignment_Menu();
            pastAssignmentsMenu.Closed += (s, args) => Close();
            pastAssignmentsMenu.Show();
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
