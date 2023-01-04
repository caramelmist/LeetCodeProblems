using System;
namespace LeetCodeProblems
{
    public class Problem2244 : Solution
    {
        public Problem2244()
        {
        }

        public void Run()
        {
            int actual = MinimumRounds(new int[] { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 });
            int expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinimumRounds(new int[] { 2, 3, 3 });
            expected = -1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinimumRounds(new int[] { 2, 2, 3, 3 });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MinimumRounds(int[] tasks)
        {
            int days = 0;
            IEnumerable<int> list = tasks.Distinct();
            Dictionary<int, int> cache = new Dictionary<int, int>();

            foreach (int l in list)
            {
                int num = tasks.Count(a => a == l);

                if (cache.ContainsKey(num))
                {
                    days += cache[num];
                    continue;
                }

                int d = 0;
                if (num < 2)
                {
                    return -1;
                }
                else if (num == 2)
                {
                    d++;
                }
                else
                {
                    int m = num % 3;
                    if (m == 0)
                    {
                        d += (num / 3);
                    }
                    else if (m == 1)
                    {
                        d += ((num / 3) - 1);
                        d += 2;
                    }
                    else if (m == 2)
                    {
                        d += (num / 3);
                        d++;
                    }
                }
                days += d;

                cache.Add(num, d);
            }

            return days;
        }
    }
}

