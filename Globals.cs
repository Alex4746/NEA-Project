using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEA_Math_Program.View;

namespace NEA_Math_Program
{
    internal class Globals
    {
        public static UserView User { get; set; }
        public static StudentViewModel Student { get; set; }
        public static TeacherViewModel Teacher { get; set; }
        public static AssignmentViewModel Assignment { get; set; }
        public static QuestionViewModel Question { get; set; }
        public static AssignmentResultViewModel AssignmentResults { get; set; }
        public static bool PracticeQuestion;
    }
}
