using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program
{
    internal class Evaluator
    {
        public static double Evaluate(Queue<string> compiledExpression, int ValueOfVariable)
        {
            //var copy = compiledExpression.ToList();
            Stack<double> resultStack = new Stack<double>();
            foreach (string CurrentToken in compiledExpression)
            {
                if (double.TryParse(CurrentToken, out double numVal))
                {
                    resultStack.Push(numVal);
                }
                else if (char.IsLetter(CurrentToken[0]))
                {
                    resultStack.Push(ValueOfVariable);
                }
                else
                {
                    double operand2 = resultStack.Pop();
                    double operand1 = resultStack.Pop();
                    double result = 0;
                    switch (CurrentToken)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            result = operand1 / operand2;
                            break;
                        case "^":
                            result = Math.Pow(operand1, operand2);
                            break;
                    }
                    resultStack.Push(result);
                }
            }
            return resultStack.Pop();
        }
        static bool IsAlgebraicTerm(string token)
        {
            bool result = false;
            for (int i = 1; i < token.Length; i++)
            {

                if (!char.IsLetter(token[i]))
                {
                    result = false;
                }
                else
                {
                    return true;
                }
            }
            return result;
        }
        static List<string> CollectLikeTerms(List<string> compiledExpression)
        {
            for (int i = 0; i < compiledExpression.Count; i++)
            {
                if (IsAlgebraicTerm(compiledExpression[i]))
                {
                    for (int j = i + 1; j < compiledExpression.Count; j++)
                    {
                        if (IsAlgebraicTerm(compiledExpression[j]) && compiledExpression[i + 1] == compiledExpression[j + 1])
                        {
                            compiledExpression[i] = (Convert.ToInt32(compiledExpression[i]) + Convert.ToInt32(compiledExpression[j])).ToString() + compiledExpression[i].Substring(1);
                            compiledExpression.RemoveAt(j);
                        }
                    }
                }
            }
            return compiledExpression;
        }
    }
}
