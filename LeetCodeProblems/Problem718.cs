using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem718 : Solution
    {
        public void Run()
        {
            int actual = FindLength(new int[] { 1, 2, 3, 2, 1 }, new int[] { 3, 2, 1, 4, 7 });
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = FindLength(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 });
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = FindLength(new int[] { 0, 1, 1, 1, 1 }, new int[] { 1, 0, 1, 0, 1 });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int FindLength(int[] nums1, int[] nums2)
        {
            int max = 0;

            for (int i = 0; i < nums1.Length-max; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if(nums1[i] == nums2[j])
                    {
                        int count = 1;
                        for (int k = 1; k < nums1.Length - i && k < nums2.Length - j; k++)
                        {
                            if (nums1[i+k] == nums2[j+k])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if(count > max)
                        {
                            max = count;
                        }
                    }
                }
            }

            return max;
        }
    }
}
