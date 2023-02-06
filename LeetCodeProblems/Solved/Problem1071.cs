using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1071 : Solution
    {
        public void Run()
        {
            string actual = GcdOfStrings("ABCABC", "ABC");
            string expected = "ABC";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("ABABABAB", "ABAB");
            expected = "ABAB";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("ABABAB", "ABAB");
            expected = "AB";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("LEET", "CODE");
            expected = "";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("AA", "AAA");
            expected = "A";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("AA", "AAAA");
            expected = "AA";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("ABAD", "ABADABADABAD");
            expected = "ABAD";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("ABAD", "ABADCABADABAD");
            expected = "";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("ABADA", "ABADAABADA");
            expected = "ABADA";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("IANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEE","IANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEEIANJUBYHEE");
            expected = "IANJUBYHEE";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = GcdOfStrings("FBFKOXFBFKOXFBFKOXFBFKOXFBFKOX", "FBFKOXFBFKOXFBFKOXFBFKOXFBFKOXFBFKOXFBFKOXFBFKOXFBFKOX");
            expected = "FBFKOX";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string GcdOfStrings(string str1, string str2)
        {
            if ((str1[0] != str2[0]) || (str1[str1.Length - 1] != str2[str2.Length - 1]))
            {
                return "";
            }

            char first = str1[0];
            char last = str1[str1.Length - 1];

            int str1Len = str1.Length;
            int str2Len = str2.Length;

            int divisor = str1Len > str2Len ? str2Len : str1Len;

            for (int i = divisor; i >= 1; i--)
            {
                divisor = i;
                if (str1Len % divisor == 0 && str2Len % divisor == 0)
                {
                    string sub = str1.Substring(0, divisor);
                    string temp = sub + "";
                    while(temp.Length <= str1Len)
                    {
                        if (temp == str1)
                        {
                            string temp1 = sub + "";
                            while (temp1.Length <= str2Len)
                            {
                                if (temp1 == str2)
                                {
                                    return sub;
                                }
                                temp1 += sub;
                            }
                        }
                        temp += sub;
                    }
                }
            }

            return "";
        }
    }
}
