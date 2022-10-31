using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2235 : Solution
    {
        public void Run()
        {
            int actual = Sum(12, 5);
            int expected = 17;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = Sum(-10, 4);
            expected = -6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
