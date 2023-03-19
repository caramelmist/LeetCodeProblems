using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2444 : Solution
    {
        public void Run()
        {
            long actual = CountSubarrays(new int[] { 1, 3, 5, 2, 7, 5 }, 1, 5);
            long expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountSubarrays(new int[] { 1, 1, 1, 1 }, 1, 1);
            expected = 10;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            if(minK == maxK)
            {
                return CountSubarrays(nums, minK);
            }

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= minK && nums[i] <= maxK)
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] >= minK && nums[j] <= maxK)
                        {
                            bool foundA = false;
                            bool foundB = false;
                            for (int k = i; k <= j; k++)
                            {
                                if (nums[k] == minK)
                                {
                                    foundA = true;
                                }
                                if (nums[k] == maxK)
                                {
                                    foundB = true;
                                }
                                if(foundA && foundB)
                                {
                                    count++;
                                    break;
                                }
                            }
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return count;
        }

        private long CountSubarrays(int[] nums, int target)
        {
            int count = 0;
            if (nums.Distinct().Count() == 1)
            {
                for (int i = 1; i <= nums.Length; i++)
                {
                    count += i;
                }
                return count;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] == target)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return count;
        }
    }
}
