using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem9 : Solution
    {
        public void Run()
        {
            bool actual = IsPalindrome(121);
            bool expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = IsPalindrome(-121);
            expected = false;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = IsPalindrome(10);
            expected = false;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);
        }

        public bool IsPalindrome(int x)
        {
            string value = x.ToString();
            int first = 0;
            int last = value.Length - 1;
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[first + i] != value[last - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
