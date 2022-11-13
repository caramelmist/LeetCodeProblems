using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem151 : Solution
    {
        public void Run()
        {
            string actual = ReverseWords("the sky is blue");
            string expected = "blue is sky the";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ReverseWords("  hello world  ");
            expected = "world hello";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ReverseWords("a good   example");
            expected = "example good a";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string ReverseWords(string s)
        {
            string[] words = s.Trim().Split(" ");
            string ret = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] == "")
                {
                    continue;
                }

                if (ret.Length == 0)
                {
                    ret = words[i];
                }
                else
                {
                    ret += " " + words[i];
                }
            }

            return ret;
        }
    }
}
