using System;
namespace LeetCodeProblems
{
    public class Problem12: Solution
    {
        public Problem12()
        {
        }

        public void Run()
        {
            string actual = IntToRoman(3);
            string expected = "III";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IntToRoman(58);
            expected = "LVIII";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IntToRoman(1994);
            expected = "MCMXCIV";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IntToRoman(2994);
            expected = "MMCMXCIV";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string IntToRoman(int num)
        {
            Dictionary<int, string> map = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC"},
                { 50, "L" },
                { 40, "XL"},
                { 10, "X" },
                { 9, "IX"},
                { 5, "V" },
                { 4, "IV"},
                { 1, "I" }
            };

            string ret = "";

            List<int> keys = map.Keys.ToList();
            foreach(int val in keys)
            {
                int digits = num / val;
                for(int i = 0; i < digits; i++)
                {
                    ret += map[val];
                }
                num -= (val * digits);
            }

            return ret;
        }
    }
}

