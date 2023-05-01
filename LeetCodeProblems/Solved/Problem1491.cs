using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1491 : Solution
    {
        public void Run()
        {
            double actual = Average(new int[] { 4000, 3000, 1000, 2000 });
            double expected = 2500.00000;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = Average(new int[] { 1000, 2000, 3000 });
            expected = 2000.00000;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public double Average(int[] salary)
        {
            int min = salary[salary.Length - 1];
            int max = salary[salary.Length - 1];
            double total = salary[salary.Length - 1];

            for (int i = salary.Length - 2; i >= 0; i--)
            {
                total += salary[i];
                if (salary[i] > max)
                {
                    max = salary[i];
                }
                else if (salary[i] < min)
                {
                    min = salary[i];
                }
            }

            return (total - (min + max)) / (salary.Length - 2);
        }
    }
}
