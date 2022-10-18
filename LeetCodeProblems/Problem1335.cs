using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1335 : Solution
    {
        public void Run()
        {
            int actual = MinDifficulty(new int[] { 6, 5, 4, 3, 2, 1 }, 2);
            int expected = 7;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 9, 9, 9 }, 4);
            expected = -1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 1, 1, 1 }, 3);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 1, 10, 20, 10, 1 }, 3);
            expected = 22;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 1, 10, 20, 10, 1 }, 2);
            expected = 21;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 1, 10, 20, 10, 1 }, 4);
            expected = 32;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 25, 1, 10, 20, 10, 1 }, 3);
            expected = 36;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 25, 1, 10, 20, 10, 1 }, 4);
            expected = 36;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 25, 1, 10, 20, 10, 1 }, 4);
            expected = 36;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDifficulty(new int[] { 25, 1, 10, 20, 10, 1 }, 2);
            expected = 26;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            if(jobDifficulty.Length > d)
            {
                return -1;
            }
            else if(jobDifficulty.Length == d)
            {
                return jobDifficulty.Sum();
            }


            return 0;
        }
    }
}
