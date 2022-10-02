using System;
using System.Linq;

namespace LeetCodeProblems
{
    public class Problem6212: Solution
    {
        public Problem6212()
        {
        }

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
        }


        public bool EqualFrequency(string word)
        {
            if (word.Length <= 1)
            {
                return false;
            }

            Dictionary<char, int> values = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (!values.ContainsKey(c))
                {
                    values.Add(c, 1);
                }
                else
                {
                    values[c]++;
                }
            }

            int min = values.Values.Min();
            int max = values.Values.Max();

            if (min == max && min == 1)
            {
                return true;
            }
            else if (max - min == 1)
            {
                int incorrect = 0;
                foreach (int i in values.Values)
                {
                    if(i != min)
                    {
                        incorrect++;
                        if(incorrect > 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            return false;
        }
            

        public bool EqualFrequency2(string word)
        {
            if(word.Length <= 1)
            {
                return false;
            }

            Dictionary<char, int> values = new Dictionary<char, int>();
            foreach(char c in word)
            {
                if (!values.ContainsKey(c))
                {
                    values.Add(c, 1);
                }
                else
                {
                    values[c]++;
                }
            }

            int expected = (int)(Math.Round(values.Values.Average()));
            bool oneOver = false;
            bool allOne = true;
            foreach (int i in values.Values)
            {
                if(i != expected)
                {
                    if (oneOver)
                    {
                        return false;
                    }
                    if (i == expected + 1 || i == expected -1)
                    {
                        oneOver = true;
                    }
                }
                if(i != 1)
                {
                    allOne = false;
                }
            }
            if (allOne)
            {
                return true;
            }

            return oneOver;
        }
    }
}

