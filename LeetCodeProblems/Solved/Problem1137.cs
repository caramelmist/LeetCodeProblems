using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1137 : Solution
    {
        public void Run()
        {
            int actual = Tribonacci(4);
            int expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = Tribonacci(25);
            expected = 1389537;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int Tribonacci(int n)
        {
            if (n < 1)
            {
                return 0;
            }

            int t0 = 0;
            int t1 = 1;
            int t2 = 1;
            for (int i = 3; i <= n; i++)
            {
                int v = t0 + t1 + t2;
                t0 = t1;
                t1 = t2;
                t2 = v;
            }

            return t2;
        }
    }
}
