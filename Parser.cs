using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program
{
    internal class Parser
    {
        public static Queue<string> Parse(List<string> tokens)
        {
            Queue<string> OutputQueue = new Queue<string>();
            Stack<string> OperationsStack = new Stack<string>();
            Dictionary<string, int> Operators = new Dictionary<string, int>();
            Operators.Add("+", 1);
            Operators.Add("-", 1);
            Operators.Add("*", 2);
            Operators.Add("/", 2);
            Operators.Add("^", 3);
            foreach (string CurrentToken in tokens)
            {
                if (int.TryParse(CurrentToken, out int operand))
                {
                    OutputQueue.Enqueue(operand.ToString());
                }
                else if (char.IsLetter(CurrentToken[0]))
                {
                    OutputQueue.Enqueue(CurrentToken);
                }
                else if (IsOperator(Operators, CurrentToken))
                {
                    while (OperationsStack.Count > 0 && IsOperator(Operators, OperationsStack.Peek()) && GetPrecedence(Operators, OperationsStack.Peek()) >= GetPrecedence(Operators, CurrentToken))
                    {
                        OutputQueue.Enqueue(OperationsStack.Pop());
                    }
                    OperationsStack.Push(CurrentToken);
                }
                else if (CurrentToken == "(")
                {
                    OperationsStack.Push(CurrentToken);
                }
                else if (CurrentToken == ")")
                {
                    while (OperationsStack.Count > 0 && OperationsStack.Peek() != "(")
                    {
                        OutputQueue.Enqueue(OperationsStack.Pop());
                    }
                    OperationsStack.Pop();
                }
            }

            while (OperationsStack.Count > 0)
            {
                OutputQueue.Enqueue(OperationsStack.Pop());
            }
            return OutputQueue;
        }
        public static bool IsOperator(Dictionary<string, int> Operators, string token)
        {
            return Operators.ContainsKey(token); //Checks if dictionary contains the token
        }

        public static int GetPrecedence(Dictionary<string, int> Operators, string token)
        {
            return Operators[token];//Returns the precedence of operator
        }
    }
}
