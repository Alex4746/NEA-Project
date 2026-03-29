using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Math_Program
{
    internal class Tokenizer
    {
        public static List<string> Tokenise(string EqToBeParsed)
        {
            int EqLength = EqToBeParsed.Length;
            List<string> tokens = new List<string>();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < EqLength; i++)
            {
                if (char.IsDigit(EqToBeParsed[i]))
                {
                    string number = "";
                    number += EqToBeParsed[i];
                    if (i != EqLength - 1)
                    {
                        if (char.IsDigit(EqToBeParsed[i + 1]))
                        {
                            number += EqToBeParsed[i + 1];
                            i++;
                        }
                    }
                    tokens.Add(number);
                }
                else if (char.IsLetter(EqToBeParsed[i]))
                {
                    tokens.Add(EqToBeParsed[i].ToString());
                }
                else if (EqToBeParsed[i] != ' ')
                {
                    tokens.Add(EqToBeParsed[i].ToString());
                }
            }
            return tokens;
        }
    }
}
