using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem20 : Solution
    {
        public void Run()
        {
            bool actual = IsValid("()");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IsValid("()[]{}");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IsValid("(]");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool IsValid(string s)
        {
            string required = "";

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        required = ')' + required;
                        break;
                    case '[':
                        required = ']' + required;
                        break;
                    case '{':
                        required = '}' + required;
                        break;
                    case ')':
                        if (required.Length > 0 && required[0] == ')')
                        {
                            required = required.Substring(1);
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (required.Length > 0 && required[0] == ']')
                        {
                            required = required.Substring(1);
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (required.Length > 0 && required[0] == '}')
                        {
                            required = required.Substring(1);
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
            }

            return required == "";
        }
    }
}
