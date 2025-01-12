using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2116 : Solution
    {
        public void Run()
        {
            bool actual = CanBeValid("))()))", "010100");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanBeValid("()()", "0000");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanBeValid("(", "0");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanBeValid("(()())", "111111");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool CanBeValid(string s, string locked)
        {
            int len = s.Length;
            if(len == 0 || len%2 == 1)
            {
                return false;
            }

            for(int i= 0; i < s.Length; i++)
            {
                if (locked[i] == '1')
                {
                    if (i%2 == 0)
                    {
                        if (s[i] == ')')
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (s[i] == '(')
                        {
                            return false;
                        }
                    }
                }
            }
            return true;

        }
    }
}
