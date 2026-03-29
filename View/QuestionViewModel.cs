using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program.View
{
    internal class QuestionViewModel
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
        public string Description { get; set; }
    }
}
