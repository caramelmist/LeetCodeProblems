using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2405 : Solution
    {
        public void Run()
        {
            int actual = PartitionString("abacaba");
            int expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = PartitionString("ssssss");
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int PartitionString(string s)
        {
            string newString = "" + s[0];
            int count = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (newString.Contains(s[i]))
                {
                    count++;
                    newString = "" + s[i];
                }
                else
                {
                    newString += s[i];
                }
            }

            return count;
        }
    }
}
