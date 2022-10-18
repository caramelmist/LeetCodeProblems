using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem38 : Solution
    {
        public void Run()
        {
            string actual = CountAndSay(1);
            string expected = "1";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountAndSay(2);
            expected = "11";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountAndSay(4);
            expected = "1211";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountAndSay(5);
            expected = "111221";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountAndSay(6);
            expected = "312211";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountAndSay(7);
            expected = "13112221";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }

        public string CountAndSay(int n)
        {
            if(n == 1)
            {
                return "1";
            }

            string ret = "1";

            for(int i = 1; i < n; i++)
            {
                ret = Compress(ret);
            }

            return ret;
        }

        private string Compress(string input)
        {
            string ret = "";
            char c = input[0];
            int num = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if(c == input[j])
                {
                    num++;
                    if (j == input.Length-1)
                    {
                        ret += num + "" + c;
                    }
                }
                else
                {
                    ret += num + "" + c;
                    num = 0;
                    c = input[j];
                    j--;
                }
            }

            return ret;
        }
    }
}
