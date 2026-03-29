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
    public partial class Create_Class_Menu : Form
    {
        private readonly UserRepository _userRepository;
        public Create_Class_Menu()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudents()
        {
            try
            {
                StudentsToAddGrid.BeginInvoke(new Action(() =>
                {
                    int idFilter = (int)IDNumeric.Value;
                    string nameFilter = NameTxtBox.Text?.Trim();
                    var students = _userRepository.GetAllStudents(idFilter, nameFilter);
                    StudentsToAddGrid.AutoGenerateColumns = false;
                    StudentsToAddGrid.DataSource = students;
                    StudentsToAddGrid.Refresh();
                    StudentsToAddGrid.ClearSelection();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Create_Class_Menu_Shown(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IDNumeric_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void CreateClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string className = Globals.Teacher.LastName + "'s Class";
                _userRepository.CreateClass(Globals.Teacher.TeacherID, className);
                MessageBox.Show("Class Created", "Class created successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStdntToClassBtn_Click(object sender, EventArgs e)
        {
            if (_userRepository.HasClass(Globals.Teacher.Email))
            {
                try
                {
                    int studentID = Convert.ToInt32(IDNumeric.Value);
                    int classID = _userRepository.GetClassID(Globals.Teacher.TeacherID);
                    _userRepository.AddStudentToClass(studentID, classID);
                    MessageBox.Show("Student Added", "Student added to class successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error adding student to class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You do not have a class. Please create one first using the button on the left.", "No Class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Class_Managment_Menu classManagmentMenu = new Class_Managment_Menu();
            classManagmentMenu.Closed += (s, args) => Close();
            classManagmentMenu.Show();
        }

        private void SearchStdntsBtn_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
