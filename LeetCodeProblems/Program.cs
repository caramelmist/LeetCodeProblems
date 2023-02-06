using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using LeetCodeProblems;
using LeetCodeProblems.Solved;

namespace LeetCodeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //A: Setup and stuff you don't want timed
            var timer = new Stopwatch();
            timer.Start();

            //B: Run stuff you want timed
            Solution s = new Problem1470();
            s.Run();

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");

            Console.WriteLine(foo);

            Console.ReadLine();
        }

        public static string Print2DArray(IList<IList<string>> matrix)
        {
            string ret = "[";
            foreach(IList<string> row in matrix)
            {
                string value = "[";
                for (int j = 0; j < row.Count; j++)
                {
                    value += row[j] + ", ";
                }
                value += "]";
                value = value.Replace(", ]", "]");
                ret += value + ",";
            }
            ret += "]";
            return ret.Replace("],]", "]]");
        }

        public static string Print2DArray<T>(T[,] matrix)
        {
            string ret = "[";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string value = "[";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    value += matrix[i, j] + ", ";
                }
                value += "]";
                value = value.Replace(", ]", "]");
                ret += value + ",";
            }
            ret += "]";
            return ret.Replace("],]", "]]");
        }

        public static string Print2DArray(IList<IList<int>> matrix)
        {
            string ret = "[";
            for (int i = 0; i < matrix.Count; i++)
            {
                string value = "[";
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    value += matrix[i][j] + ", ";
                }
                value += "]";
                value = value.Replace(", ]", "]");
                ret += value + ",";
            }
            ret += "]";
            return ret.Replace("],]", "]]");
        }

        /*
        public static void RunRotate()
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] expected = new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i, j] != expected[i, j])
                    {
                        Console.WriteLine("Matrix does not match expected.");
                        break;
                    }
                }
            }
            Console.WriteLine("Test Passed.");
        }

        public static void Rotate(int[][] matrix)
        {

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] sol = { i, j };
                        return sol;
                    }
                }
            }
            // should not ever get here according to assumptions
            return new int[] { 0 };
        }
    }

    
        */
    }
}