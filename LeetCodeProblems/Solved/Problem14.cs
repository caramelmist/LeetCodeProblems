using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem14 : Solution
    {
        public void Run()
        {
            string actual = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            string expected = "fl";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LongestCommonPrefix(new string[] { "" });
            expected = "";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LongestCommonPrefix(new string[] { "ab", "a" });
            expected = "a";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string ret = "";
            int len = strs[0].Length;

            for (int i = 0; i < len; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i || c != strs[j][i])
                    {
                        return ret;
                    }
                }

                ret += c;
            }

            return ret;
        }
    }
}
