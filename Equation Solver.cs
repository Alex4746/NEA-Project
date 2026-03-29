using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program
{
    internal class Equation_Solver
    {
        static public string SolveExpression(string Expression)
        {
            Queue<string> parsedExpression = Parser.Parse(Tokenizer.Tokenise(Expression));
            return Evaluator.Evaluate(parsedExpression, 0).ToString();
        }
        static public double SolveAlgebraicEquation(string Equation)
        {
            var parts = Equation.Split('=');
            string leftSide = parts[0];
            string rightSide = parts[1];

            Queue<string> parsedLeftSide = Parser.Parse(Tokenizer.Tokenise(leftSide));
            Queue<string> parsedRightSide = Parser.Parse(Tokenizer.Tokenise(rightSide));

            double LHSResultAt0 = Evaluator.Evaluate(parsedLeftSide, 0);
            double LHSResultAt1 = Evaluator.Evaluate(parsedLeftSide, 1);
            double RHSResultAt0 = Evaluator.Evaluate(parsedRightSide, 0);
            double RHSResultAt1 = Evaluator.Evaluate(parsedRightSide, 1);

            double a = LHSResultAt1 - LHSResultAt0;
            double b = LHSResultAt0;
            double c = RHSResultAt0;

            return (c - b) / a;
        }
    }
}
