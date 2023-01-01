using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem290 : Solution
    {
        public void Run()
        {
            bool actual = WordPattern("abba", "dog cat cat dog");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = WordPattern("abba", "dog cat cat fish");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = WordPattern("aaaa", "dog cat cat dog");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(" ");
            if(pattern.Length != words.Length)
            {
                return false;
            }

            Dictionary<char, string> map = new Dictionary<char, string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!map.ContainsKey(pattern[i]))
                {
                    if (map.ContainsValue(words[i]))
                    {
                        return false;
                    }
                    map.Add(pattern[i], words[i]);
                }

                if (words[i] != map[pattern[i]])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
