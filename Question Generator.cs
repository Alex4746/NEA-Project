using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program
{
    internal class Question_Generator
    {
        static public string GenerateQuestion(int difficulty, int questionType)
        {
            Random random = new Random();//Initialise objects for each class
            Number number = new Number(difficulty, questionType);
            Operator @operator = new Operator(difficulty, questionType);
            Conditions conditions = new Conditions(difficulty, questionType);

            string expression = AddToExpression(conditions, number, @operator, random);//Call function to generate expression then assign result to variable
            return expression;
        }
        class Conditions
        {
            static public Random random = new Random();
            public Random Random { get { return random; } }
            public int Difficulty { get; }
            public int NumOfSteps { get; set; }
            public int NumOfBrackets { get; set; }
            public int QuestionType { get; set; }
            public Conditions(int difficulty, int questionType)
            {
                Difficulty = difficulty;
                QuestionType = questionType;
                NumOfSteps = 2 + difficulty;
                NumOfBrackets = difficulty - 1;
            }

            public bool WillContainBrackets(Random random)
            {
                return random.Next(1, 2) == 1;  // Note: Next(1,2) always returns 1
            }
        }
        class Number : Conditions
        {
            static public int GetUpperLimit(int difficulty)//Gets the highest integer each difficulty can have
            {
                switch (difficulty)
                {
                    case 1:
                        return 10;

                    case 2:
                        return 16;

                    case 3:
                        return 21;

                }
                return 0;
            }
            public bool IsDecimal(Random random)//Checks if the number will be a decimal
            {
                return random.Next(1) == 1;
            }
            public bool IsNegative(Random random)//Checks if the number will be a decimal
            {
                return random.Next(1) == 1;
            }
            public bool HasCoefficient(Random random)//Checks if the variable will have a coefficient
            {
                return random.Next(2) == 0;
            }

            public int Value { get; set; }
            public char Variable { get; set; }
            public int Coefficient { get; set; }
            public bool HasVariable { get; set; }
            public Number(int difficulty, int questionType) : base(difficulty, questionType)
            {
                Value = random.Next(1, GetUpperLimit(Difficulty));//Gets the value of the number
                Variable = 'x';
                Coefficient = random.Next(1, 6);
            }
        }
        class Operator : Conditions
        {
            public static string[] AllOperators = { "+", "-", "*", "/" };
            public string[] operatorsLeft = { "+", "-", "*", "/" };//Field containing all the operators that can be added to the expression next
            public int NumOfOperators = AllOperators.Length - 1;//Field storing the number of operators for when one needs to be randomly selected
            public string _operator = "";

            public Operator(int difficulty, int questionType) : base(difficulty, questionType)
            {
            }

            public string GetOperator(Random random, string[] operators)//Function that randomly selects operator from an array
            {
                operators = RefillOpList(operators);//If the array is empty, it is refilled with all of the operators
                NumOfOperators = RefillOpList(operators).Length - 1;//Gets length of new array
                return operators[Random.Next(0, NumOfOperators + 1)];
            }

            public void RemoveOperatorUsed(string currentOp)//Function to remove operator that has already been used to avoid repeats
            {
                operatorsLeft = Array.FindAll(operatorsLeft, element => element != currentOp);//Goes through the given array, returns an array that contains the elements that satisfy the condition
                NumOfOperators = operatorsLeft.Length - 1;
            }

        }

        static string AddToExpression(Conditions conditions, Number num, Operator op, Random random)//Function that generates the expression
        {
            string expression = "";
            if (conditions.QuestionType == 1)
            {
                for (int i = 0; i < conditions.NumOfSteps - 1; i++)
                {
                    if (i == conditions.NumOfSteps - 2)//If the current term is the last term, an equals sign and another number is added to the expression instead of an operator and another term
                    {
                        expression += num.Value;
                        expression += "=";
                        expression += random.Next(1, 10);
                    }
                    else
                    {
                        op._operator = op.GetOperator(random, op.operatorsLeft);
                        if (!num.HasVariable)//Adds variable to expression based on result of function
                        {
                            if (num.HasCoefficient(random) == true)//If the variable has a coefficient, add it to the expression
                            {
                                expression += num.Coefficient;
                                expression += "*";
                            }
                            expression += num.Variable;
                            num.HasVariable = true;//Ensures only 1 variable is added to the expression
                        }
                        else
                        {
                            expression += random.Next(1, 10);
                            
                        }
                        if (i < conditions.NumOfSteps - 2)
                        {
                            expression += op._operator;//Adds current operator then removes it from operatorsLeft array
                            op.RemoveOperatorUsed(op._operator);
                        }
                    }
                }
                return expression;
            }
            else if (conditions.Difficulty == 1)
            {
                string previousOp = "";
                for (int i = 0; i < conditions.NumOfSteps; i++)
                {
                    expression += random.Next(1,10);//Adds value to the expression
                    if (i < conditions.NumOfSteps - 1)
                    {
                        if (previousOp != "*" && previousOp != "/")//Stops * and / from appearing more than once
                        {
                            previousOp = op.operatorsLeft[op.Random.Next(0, 4)];
                            expression += previousOp;
                        }
                        else
                        {
                            previousOp = op.operatorsLeft[op.Random.Next(0, 2)];
                            expression += previousOp;
                        }
                    }
                }
                return expression;
            }
            else if (conditions.Difficulty == 2)
            {

                for (int i = 0; i < conditions.NumOfSteps; i++)
                {
                    op._operator = op.GetOperator(random, op.operatorsLeft);


                    if (num.IsDecimal(random) == true && op._operator != "^")//Adds decimal number to expression based on result of function, ensures a decimal number can't have the ^ operator
                    {
                        double unroundedNum = random.NextDouble() * 10;
                        double decimalNum = Math.Round(unroundedNum, 2);
                        expression += decimalNum;
                    }
                    else if (num.IsNegative(random) == true && op._operator != "^")//Adds negative number to expression based on result of function, ensures a negative number can't have the ^ operator
                    {
                        int temp = random.Next(1, 10);
                        expression += -temp;
                    }
                    else
                    {
                        expression += random.Next(1, 10);
                    }
                    if (i < conditions.NumOfSteps - 1)
                    {
                        if (op._operator == "^")//If the current operator is ^ then a number between 1-4 is added, then ^ is removed from the operatorsLeft array, then another operator is added to the expression and removed from the array
                        {
                            expression += op._operator;
                            expression += random.Next(1, 5);
                            op.RemoveOperatorUsed(op._operator);
                            string x = op.GetOperator(random, op.operatorsLeft);
                            op.RemoveOperatorUsed(x);
                            expression += x;
                        }
                        else
                        {
                            expression += op._operator;//Adds current operator then removes it from operatorsLeft array
                            op.RemoveOperatorUsed(op._operator);
                        }
                    }
                }
                if (conditions.WillContainBrackets(random) == true)//If the function returns true, addBrackets function will return the expression with brackets inserted in random places
                {
                    expression = AddBrackets(expression, random, op, conditions);
                    return expression;
                }
                else
                {
                    return expression;
                }
            }
            else if (conditions.Difficulty == 3)
            {
                for (int i = 0; i < conditions.NumOfSteps; i++)
                {
                    op._operator = op.GetOperator(random, op.operatorsLeft);
                    if (num.IsDecimal(random) == true && op._operator != "^")//Adds decimal number to expression based on result of function, ensures a decimal number can't have the ^ operator
                    {
                        double unroundedNum = random.NextDouble() * 10;
                        double decimalNum = Math.Round(unroundedNum, 2);
                        expression += decimalNum;
                    }
                    else if (num.IsNegative(random) == true && op._operator != "^")//Adds negative number to expression based on result of function, ensures a negative number can't have the ^ operator
                    {
                        int temp = random.Next(1, 10);
                        expression += -temp;
                    }
                    else
                    {
                        expression += random.Next(1, 10);
                    }
                    if (i < conditions.NumOfSteps - 1)
                    {
                        if (op._operator == "^")//If the current operator is ^ then a number between 1-5 is added, then ^ is removed from the operatorsLeft array, then another operator is added to the expression and removed from the array
                        {
                            expression += op._operator;
                            expression += random.Next(1, 5);
                            op.RemoveOperatorUsed(op._operator);
                            string x = op.GetOperator(random, op.operatorsLeft);
                            op.RemoveOperatorUsed(x);
                            expression += x;

                        }
                        else
                        {
                            expression += op._operator;//Adds current operator then removes it from operatorsLeft array
                            op.RemoveOperatorUsed(op._operator);

                        }
                    }
                }
                if (conditions.WillContainBrackets(random) == true)//If the function returns true, addBrackets function will return the expression with brackets inserted in random places
                {
                    expression = AddBrackets(expression, random, op, conditions);
                    return expression;
                }
                else//No brackets added
                {
                    return expression;
                }
            }

            return expression;
        }

        static string AddBrackets(string expression, Random random, Operator op, Conditions conditions)
        {
            int expLength = expression.Length;
            List<string> tokens = new List<string>();
            string number = "";
            for (int i = 0; i < expLength; i++)//Tokenizes the string expression so that brackets may be inserted into the created list then reverted back into a string
            {
                if (char.IsDigit(expression[i]) || expression[i] == '.' || IsUnaryOperator(expression, i))//Ensures that integers, decimals, and negative numbers all occupy 1 index within the list
                {
                    number += expression[i].ToString();
                }
                else
                {
                    if (number.Length > 0)//If the token is an operator, than the number is added to the list ensuring that no numbers are split up, only then is the operator added to the list
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    tokens.Add(expression[i].ToString());
                }
            }
            if (number.Length > 0)//Ensures no number is missed
            {
                tokens.Add(number);
            }
            List<(int start, int end)> bracketRanges = new List<(int, int)>();//Stores the range of the previous brackets
            for (int i = conditions.NumOfBrackets; i > 0; i--)
            {
                int leftBracketPos;
                int rightBracketPos;
                do//do while loop to allow the block of code to run once, then loops until the conditions is satisfied
                {
                    leftBracketPos = GetLeftBracketPos(tokens, random);
                    rightBracketPos = GetRightBracketPos(leftBracketPos, tokens);
                }
                while (!IsValidBracketRange(leftBracketPos, rightBracketPos, bracketRanges));//Ensures the bracket pairs will not overlap
                tokens.Insert(leftBracketPos, "(");
                tokens.Insert(rightBracketPos + 1, ")");

                bracketRanges.Add((leftBracketPos, rightBracketPos + 1));//Adds the ranges to the list 
            }
            expression = "";
            foreach (var item in tokens)//Turns the list of tokens back into a string
            {
                expression += item;
            }
            return expression;
        }
        static bool IsUnaryOperator(string expression, int i)//Checks for the unary operator "-" so that the tokenizer can differentiate between negative numbers and the subtract sign
        {
            char[] operators = new char[] { '+', '-', '*', '/', '^' };
            if (expression.Length > 0 && i > 0)
            {
                if (operators.Contains(expression[i - 1]) || expression[0] == expression[i] || expression[i - 1] == '(')//Conditions that determine whether a "-" sign is a negative number or just a subtract sign
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        static bool IsUnaryOperator(List<string> tokens, int i)//Overload of previous function to accept lists of strings
        {
            string[] operators = new string[] { "+", "-", "*", "/", "^" };
            if (tokens.Count > 0 && i > 0)
            {
                if (operators.Contains(tokens[i - 1]) || tokens[0] == tokens[i] || tokens[i - 1] == "(")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        static int GetLeftBracketPos(List<string> tokens, Random random)
        {
            int pos = 0;
            do
            {
                pos = random.Next(0, tokens.Count - 1);
            }
            while (!char.IsDigit(tokens[pos][0]) && !IsUnaryOperator(tokens, pos));
            return pos;
        }
        static int GetRightBracketPos(int leftBracket, List<string> tokens)
        {
            List<int> suitablePos = new List<int>();
            Random random = new Random();
            string[] operators = new string[] { "+", "-", "*", "/", "^" };
            for (int i = leftBracket + 1; i < tokens.Count; i++)
            {
                if (char.IsDigit(tokens[i][0]))
                {
                    if (i == tokens.Count - 1 || operators.Contains(tokens[i + 1]))
                    {
                        suitablePos.Add(i + 1);
                    }
                    else if (tokens[i + 1] == ".")
                    {
                        suitablePos.Add(i + 3);
                    }
                    else if (IsUnaryOperator(tokens, i))
                    {
                        suitablePos.Add(i + 2);
                    }
                }
            }
            if (suitablePos.Count == 0)
            {
                suitablePos.Add(tokens.Count - 1);
            }
            return suitablePos[random.Next(0, suitablePos.Count)];
        }
        static string[] RefillOpList(string[] operatorsLeft)
        {
            string[] allOperators = new string[] { "+", "-", "*", "/", "^" };
            if (operatorsLeft.Length == 0)
            {
                return allOperators;
            }
            else
            {
                return operatorsLeft;
            }
        }
        static bool IsValidBracketRange(int newLeft, int newRight, List<(int start, int end)> ranges)
        {
            foreach (var (start, end) in ranges)
            {
                bool insideStart = newLeft > start && newLeft < end;
                bool insideEnd = newRight > start && newRight < end;

                if (insideStart ^ insideEnd)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
