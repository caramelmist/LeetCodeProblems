using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem67 : Solution

    {
        public void Run()
        {
            string actual = AddBinary("11", "1");
            string expected = "100";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = AddBinary("1010", "1011");
            expected = "10101";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string AddBinary(string a, string b)
        {
            string ret = "";
            string max = a.Length > b.Length ? a : b;
            string min = b == max ? a : b;

            int carry = 0;

            for (int i = 0; i < max.Length; i++)
            {
                int first = max[max.Length - 1 - i] - '0';
                int second = 0;

                if (i < min.Length)
                {
                    second = min[min.Length - 1 - i] - '0';
                }

                int sum = first + second + carry;
                carry = 0;

                if (sum > 1)
                {
                    carry = 1;
                }

                if (sum == 2 || sum == 0)
                {
                    ret = ret.Insert(0, "0");
                }
                else
                {
                    ret = ret.Insert(0, "1");
                }
            }
            if (carry != 0)
            {
                ret = ret.Insert(0, "1");
            }

            return ret;
        }
    }
}
