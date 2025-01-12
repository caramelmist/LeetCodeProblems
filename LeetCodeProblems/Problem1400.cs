using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1400 : Solution
    {
        public void Run()
        {
    bool actual = CanConstruct("annabelle", 2);
    bool expected = true;
    Console.WriteLine("Outcome: {0} {1}", expected, actual);

    actual = CanConstruct("leetcode", 3);
    expected = false;
    Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("true", 4);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("aba", 1);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("aba", 2);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("abba", 2);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("abca", 2);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("babca", 2);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("babcca", 2);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("babdca", 2);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("babdcea", 2);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanConstruct("messi", 3);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool CanConstruct(string s, int k)
        {
            if (s.Length == k)
            {
                return true;
            }
            else if (s.Length < k)
            {
                return false;
            }

            int f = 0;
            bool[] flagged = new bool[s.Length];
            for (int i = 0; i < s.Length-1; i++)
            {
                if (flagged[i])
                {
                    continue;
                }

                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        flagged[i] = true;
                        flagged[j] = true;
                        f += 2;
                        break;
                    }
                }
            }

            int left = s.Length - f;
            return left <= f / 2;
        }
    }
}
