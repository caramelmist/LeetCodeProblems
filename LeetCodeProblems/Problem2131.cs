using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2131 : Solution
    {
        public void Run()
        {
            int actual = LongestPalindrome(new string[] { "lc", "cl", "gg" });
            int expected = 6;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = LongestPalindrome(new string[] { "ab", "ty", "yt", "lc", "cl", "ab" });
            expected = 8;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = LongestPalindrome(new string[] { "cc", "ll", "xx" });
            expected = 2;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);
        }

        public int LongestPalindrome(string[] words)
        {
            IEnumerable<string> doubles = words.Where(a => a[0] == a[1]);
            IEnumerable<string> mismatched = words.Where(a => a[0] != a[1]);

            //abaccaba
            //abccba
            //abba
            //aa



            return 0;
        }
    }
}

