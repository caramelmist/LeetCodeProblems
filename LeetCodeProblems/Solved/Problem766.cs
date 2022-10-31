using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem766 : Solution
    {
        public void Run()
        {
            bool actual = IsToeplitzMatrix(new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3 }, new int[] { 9, 5, 1, 2 } });
            bool expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = IsToeplitzMatrix(new int[][] { new int[] { 1, 2 }, new int[] { 2, 2 } });
            expected = false;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);
        }

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int vLength = matrix.Length;
            int hLength = matrix[0].Length;


            for (int i = 0; i < hLength; i++)
            {
                int j = 0;
                int value = matrix[j][i];
                while (j < vLength && i + j < hLength)
                {
                    if (matrix[j][i + j] != value)
                    {
                        return false;
                    }
                    j++;
                }
            }

            for (int j = 1; j < vLength; j++)
            {
                int i = 0;
                int value = matrix[j][i];
                while (j + i < vLength && i < hLength)
                {
                    if (matrix[j + i][i] != value)
                    {
                        return false;
                    }
                    i++;
                }
            }

            return true;
        }
    }
}
