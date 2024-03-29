﻿using System;
namespace LeetCodeProblems.Solved
{
    public class Problem1578 : Solution
    {
        public Problem1578()
        {
        }

        public void Run()
        {
            int actual = MinCost("abaac", new int[] { 1, 2, 3, 4, 5 });
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("abc", new int[] { 1, 2, 3 });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aabaa", new int[] { 1, 2, 3, 4, 1 });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aaabc", new int[] { 1, 2, 3, 4, 1 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aaabc", new int[] { 3, 2, 1, 4, 1 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aaabc", new int[] { 2, 3, 1, 4, 1 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aaabc", new int[] { 2, 1, 3, 4, 1 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aaabbbabbbb", new int[] { 3, 5, 10, 7, 5, 3, 5, 5, 4, 8, 1 });
            expected = 26;
            // 3 + 5 + 5 + 3 + 4 + 5 + 1
            Console.WriteLine("Outcome: {0} {1}", expected, actual);


            actual = MinCost("acaaaacccc", new int[] { 9, 3, 9, 8, 8, 3, 2, 7, 6, 6 });
            expected = 33;
            // 8 + 8 + 3 + 2 + 6 + 6
            Console.WriteLine("Outcome: {0} {1}", expected, actual);


            actual = MinCost("baab", new int[] { 8, 7, 2, 10 });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinCost("aaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbbaaaaabbbbb", new int[] { 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1 });
            expected = 128;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MinCost(string colors, int[] neededTime)
        {
            int result = 0;
            int len = colors.Length - 1;

            int idx = 0;
            int next = 1;

            while (true)
            {
                if (next > len)
                {
                    break;
                }

                if (colors[idx] == colors[next])
                {
                    if (neededTime[idx] > neededTime[next])
                    {
                        result += neededTime[next];
                        next++;
                    }
                    else
                    {
                        result += neededTime[idx];
                        idx = next;
                        next++;
                    }
                }
                else
                {
                    idx = next;
                    next++;
                }
            }

            return result;
        }

        public int MinCost2(string colors, int[] neededTime)
        {
            int result = 0;
            int len = colors.Length - 1;

            List<int> removed = new List<int>();

            for (int i = 0; i < len; i++)
            {
                while (removed.Contains(i))
                {
                    i++;
                    if (i >= len)
                    {
                        return result;
                    }
                }

                int offset = 1;
                while (removed.Contains(i + offset))
                {
                    offset++;
                    if (i + offset > len)
                    {
                        return result;
                    }
                }

                if (colors[i] == colors[i + offset])
                {
                    if (neededTime[i] > neededTime[i + offset])
                    {
                        result += neededTime[i + offset];
                        removed.Add(i + offset);
                        // move one back so we can keep i on the same number for the next compare
                        i--;
                    }
                    else
                    {
                        result += neededTime[i];
                        removed.Add(i);
                    }
                }
            }

            return result;
        }
    }
}

