using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2423 : Solution
    {
        public void Run()
        {
            bool actual = EqualFrequency("abcc");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("aazz");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("bac");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("abbcc");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("abcc");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("aabcc");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("aabbccd");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("aabbccddd");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("aabbccdd");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("a");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("ddaccb");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("zz");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("cccd");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("cbccca");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualFrequency("aaaabbbbccc");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool EqualFrequency(string word)
        {
            if (word.Length <= 1)
            {
                return false;
            }

            IEnumerable<char> chars = word.Distinct();
            if (chars.Count() == word.Length || chars.Count() == 1)
            {
                return true;
            }

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char ch in chars)

            {
                int count = word.Count(a => a == ch);
                counts.Add(ch, count);
            }

            List<int> diffs = counts.Values.Distinct().ToList();
            if(diffs.Count() == 2)
            {
                int min = counts.Values.Min();
                int max = counts.Values.Max();

                if(counts.Values.Count(a => a == max) == 1)
                {
                    int diff = Math.Abs(max - min);
                    if (diff == 1)
                    {
                        return true;
                    }
                }
                if (min == 1 && counts.Values.Count(a => a == min) == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
