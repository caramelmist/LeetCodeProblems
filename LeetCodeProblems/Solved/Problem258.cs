using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem258 : Solution
    {
        public void Run()
        {
            int actual = AddDigits(38);
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = AddDigits(0);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = AddDigits(10);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int AddDigits(int num)
        {
            int sum = 0;
            do
            {
                sum += num % (10);
                num /= 10;
                if (num == 0 && sum > 9)
                {
                    num = sum;
                    sum = 0;
                }
            } while (num > 0);

            return sum;
        }
    }
}
