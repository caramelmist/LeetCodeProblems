using System;
namespace LeetCodeProblems
{
    public class Problem13: Solution
    {
        public Problem13()
        {
        }

        public void Run()
        {
            int actual = RomanToInt("III");
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = RomanToInt("LVIII");
            expected = 58;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = RomanToInt("MCMXCIV");
            expected = 1994;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int RomanToInt(string s)
        {
            s = s.Replace("IV", "A").Replace("IX", "B").Replace("XL", "E").Replace("XC", "F").Replace("CD", "G").Replace("CM", "H");

            int value = 0;

            foreach (char c in s)
            {
                switch (c)
                {
                    case 'I':
                        value += 1;
                        break;
                    case 'V':
                        value += 5;
                        break;
                    case 'X':
                        value += 10;
                        break;
                    case 'L':
                        value += 50;
                        break;
                    case 'C':
                        value += 100;
                        break;
                    case 'D':
                        value += 500;
                        break;
                    case 'M':
                        value += 1000;
                        break;
                    case 'A':
                        value += 4;
                        break;
                    case 'B':
                        value += 9;
                        break;
                    case 'E':
                        value += 40;
                        break;
                    case 'F':
                        value += 90;
                        break;
                    case 'G':
                        value += 400;
                        break;
                    case 'H':
                        value += 900;
                        break;
                }
            }

            return value;
        }
    }
}

