using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program.View
{
    internal class QuestionResultViewModel
    {
        public bool IsCorrect { get; set; }
        public string Response { get; set; }
        public string CorrectAnswer { get; set; }
        public int TimeTakenSeconds { get; set; }

    }
}
