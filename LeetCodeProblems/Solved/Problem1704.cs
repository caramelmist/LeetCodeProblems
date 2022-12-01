using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    class Problem1704 : Solution
    {
        public void Run()
        {
            bool actual = HalvesAreAlike("book");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = HalvesAreAlike("textbook");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool HalvesAreAlike(string s)
        {
            int half = s.Length / 2;
            s = s.ToLower();

            int countA = 0;
            int countB = 0;

            for (int i= 0; i < half; i++)
            {
                if (IsVowel(s[i]))
                {
                    countA++;
                }
                if (IsVowel(s[half+i]))
                {
                    countB++;
                }
            }

            return countA == countB;
        }

        private static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
