using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1544 : Solution
    {
        public void Run()
        {
            string actual = MakeGood("leEeetcode");
            string expected = "leetcode";
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = MakeGood("abBAcC");
            expected = "";
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = MakeGood("s");
            expected = "s";
            Console.WriteLine("Expected matches actual: {0}", expected == actual);
        }

        public string MakeGood(string s)
        {

        }
    }
}
