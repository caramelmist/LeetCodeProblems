using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1572 : Solution
    {
        public void Run()
        {
            int actual = DiagonalSum(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
            int expected = 25;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DiagonalSum(new int[][] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 } });
            expected = 9;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DiagonalSum(new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } });
            expected = 8;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DiagonalSum(new int[][] { new int[] { 7, 3, 1, 9 }, new int[] { 3, 4, 6, 9 }, new int[] { 6, 9, 6, 6 }, new int[] { 9, 5, 8, 5 } });
            expected = 55;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DiagonalSum(new int[][] { new int[] { 5 } });
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;

            for (int i = 0, j = mat.Length - 1; i < mat.Length; i++, j--)
            {
                sum += mat[i][i];
                if(i != j)
                {
                    sum += mat[i][j];
                }
            }

            return sum;
        }
    }
}
