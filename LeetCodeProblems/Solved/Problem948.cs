using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem948 : Solution
    {
        public void Run()
        {
            int[] tokens = new int[] { 100 };
            int power = 50;
            int actual = BagOfTokensScore(tokens, power);
            int expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 100, 200 };
            power = 150;
            actual = BagOfTokensScore(tokens, power);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 100, 200, 300, 400 };
            power = 200;
            actual = BagOfTokensScore(tokens, power);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 25, 99 };
            power = 99;
            actual = BagOfTokensScore(tokens, power);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 52, 65, 35, 88, 28, 1, 4, 68, 56, 95 };
            power = 94;
            actual = BagOfTokensScore(tokens, power);
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int BagOfTokensScore(int[] tokens, int power)
        {
            List<int> ts = tokens.ToList();
            ts.Sort();

            int score = 0;

            while (ts.Count > 0)
            {
                while (ts.Count > 0 && ts[0] <= power)
                {
                    power -= ts[0];
                    ts.Remove(ts[0]);
                    score++;
                }

                if (ts.Count <= 1)
                {
                    break;
                }

                int k = 0;
                int reqPower = ts[0];
                while (ts.Count > 0 && reqPower > power && (score + k) > 0)
                {
                    int value = ts[ts.Count - 1];
                    power += value;
                    k++;
                    if (reqPower <= power)
                    {
                        score -= k;
                        ts.RemoveAt(ts.Count - 1);
                    }
                    else if (ts.Count > k)
                    {
                        reqPower += ts[k];
                    }
                }

                if (k == 0)
                {
                    break;
                }
            }

            return score;
        }
    }
}
