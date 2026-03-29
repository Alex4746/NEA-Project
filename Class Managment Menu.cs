using NEA_Math_Program.Controller;
using NEA_Math_Program.View;
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
    public partial class Class_Managment_Menu : Form
    {
        private readonly UserRepository _userRepository;
        private List<StudentViewModel> students;
        public Class_Managment_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            students = new List<StudentViewModel>();


        }
        private void Class_Managment_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadStudents()
        {
                int classID = _userRepository.GetClassID(Globals.Teacher.TeacherID);
                NumOfStudentsLbl.Text = $"{_userRepository.GetNumOfStudents(classID)}";
                ClassNameLbl.Text = $"{Globals.Teacher.LastName}'s Class";
                StudentGrid.BeginInvoke(new Action(() =>
                {
                    int idFilter = (int)IDNumeric.Value;
                    string nameFilter = LastNameTxtBox.Text?.Trim();
                    students = _userRepository.GetStudents(classID, idFilter, nameFilter);
                    StudentGrid.AutoGenerateColumns = false;
                    StudentGrid.DataSource = students;
                    StudentGrid.Refresh();
                    StudentGrid.ClearSelection();
                }));
        }

        private void Class_Managment_Menu_Shown(object sender, EventArgs e)
        {
            
            if (_userRepository.HasClass(Globals.Teacher.Email))
            {
                LoadStudents();
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

        private void SearchStdntsBtn_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            
                int studentID = Convert.ToInt32(IDToRemoveNumeric.Value);
                int classID = _userRepository.GetClassID(Globals.Teacher.TeacherID);
                _userRepository.AddStudentToClass(studentID, classID);
                LoadStudents();
                NumOfStudentsLbl.Text = $"{_userRepository.GetNumOfStudents(classID)}";
                MessageBox.Show("Student Added", "Student added to class successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = (int)StudentGrid.CurrentRow.Cells["StudentIDColumn"].Value;
                int classID = _userRepository.GetClassID(Globals.Teacher.TeacherID);
                var confirm = MessageBox.Show($"Remove student {studentID} from class?", "Confirm remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                if (!_userRepository.RemoveStudentFromClass(studentID, classID))
                {
                    MessageBox.Show("Student was not found in the class or could not be removed.", "Not removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LoadStudents();
                MessageBox.Show("Student removed from class successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error removing student from class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BacktoMainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Teacher_Main_Menu teacherMainMenu = new Teacher_Main_Menu();
            teacherMainMenu.Closed += (s, args) => Close();
            teacherMainMenu.Show();
        }
    }
}
