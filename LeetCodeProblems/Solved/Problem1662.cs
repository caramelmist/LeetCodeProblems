using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1662 : Solution
    {
        public void Run()
        {
            bool actual = ArrayStringsAreEqual(new string[] { "ab", "c" }, new string[] { "a", "bc" });
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ArrayStringsAreEqual(new string[] { "a", "cb" }, new string[] { "ab", "c" });
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ArrayStringsAreEqual(new string[] { "abc", "d", "defg" }, new string[] { "abcddefg" });
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string v1 = string.Join("", word1);
            string v2 = string.Join("", word2);

            return v1.Equals(v2);
        }
    }
}
