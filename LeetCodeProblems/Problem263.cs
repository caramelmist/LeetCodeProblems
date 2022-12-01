using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem263 : Solution
    {
        public void Run()
        {
            bool actual = IsUgly(6);
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IsUgly(1);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = IsUgly(14);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool IsUgly(int n)
        {
            if(n < 6)
            {
                return false;
            }


        }
    }
}
