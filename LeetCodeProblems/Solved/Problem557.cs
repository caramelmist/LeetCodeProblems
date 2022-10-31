using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem557 : Solution
    {
        public void Run()
        {
            string actual = ReverseWords("Let's take LeetCode contest");
            string expected = "s'teL ekat edoCteeL tsetnoc";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ReverseWords("God Ding");
            expected = "doG gniD";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string ReverseWords(string s)
        {
            string[] parts = s.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                char[] charArray = parts[i].ToCharArray();
                Array.Reverse(charArray);
                parts[i] = new string(charArray);
            }

            string answer = string.Join(' ', parts);
            return answer;
        }
    }
}
