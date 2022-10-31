using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem859 : Solution
    {
        public void Run()
        {
            bool solved = BuddyStrings("ab", "ba");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("sideshj", "jsidesh");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("ab", "ab");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("aa", "aa");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("abcd", "cbad");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("abed", "cbad");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("cbadd", "cbad");
            Console.WriteLine("[{0}]", solved);
        }

        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length || s.Length <= 1)
            {
                return false;
            }

            // same word, can swap same letter
            if (s.Equals(goal))
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            // different words
            int swapA = -1;
            int swapB = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == swapB)
                {
                    // we need to keep checking if there is more than one letter to swap
                    continue;
                }

                if (s[i] != goal[i])
                {
                    if (swapA != -1)
                    {
                        // this means that we are here the second time around
                        return false;
                    }

                    swapA = i;
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == goal[j] && s[j] == goal[i])
                        {
                            swapB = j;
                        }
                    }

                    if (swapB == -1)
                    {
                        // we did not find a matching swap
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
