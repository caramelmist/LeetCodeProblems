using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem134 : Solution
    {
        public void Run()
        {
            int actual = CanCompleteCircuit(new int[] { 1,2,3,4,5 }, new int[] { 3, 4,5, 1, 2 });
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanCompleteCircuit(new int[] {2, 3, 4 }, new int[] { 3, 4, 3 });
            expected = -1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            return 1;
        }
    }
}
