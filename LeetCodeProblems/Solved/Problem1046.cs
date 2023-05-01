using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1046 : Solution
    {
        public void Run()
        {
            int actual = LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 1 });
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 3 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 10, 6 });
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 6, 10 });
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 10, 10 });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 20, 70, 40, 10, 5, 80 });
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LastStoneWeight(new int[] { 3, 7, 2 });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int LastStoneWeight(int[] stones)
        {
            int left = stones.Length;
            if (left == 1)
            {
                return stones[0];
            }

            int largest = 0;

            do
            {
                largest = stones[0] > stones[1] ? 0 : 1;
                int secondLargest = largest == 0 ? 1 : 0;

                left = stones[largest] > 0 ? 1 : 0;
                left += stones[secondLargest] > 0 ? 1 : 0;

                for (int i = 2; i < stones.Length; i++)
                {
                    if (stones[i] > 0)
                    {
                        left++;
                        if (stones[i] > stones[largest])
                        {
                            if (stones[largest] > stones[secondLargest])
                            {
                                secondLargest = largest;
                            }
                            largest = i;
                        }
                        else if (stones[i] > stones[secondLargest])
                        {
                            secondLargest = i;
                        }
                    }
                }

                int diff = stones[largest] - stones[secondLargest];
                stones[secondLargest] = 0;
                stones[largest] = diff;

            } while (left > 1);

            return stones[largest];
        }
    }
}
