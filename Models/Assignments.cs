using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program.Models
{
    internal class Assignments
    {
            public int AssignmentID { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime DueDate { get; set; }
            public int TeacherID { get; set; }
    }
}
