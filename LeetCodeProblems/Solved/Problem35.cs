using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem35 : Solution
    {
        public void Run()
        {
            int actual = SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 1, 3, 5, 6 }, 1);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 1, 3, 5, 6 }, 3);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 1, 3, 5, 6 }, 6);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 1);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 2);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 3);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 4);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 5);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 6);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 7);
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 8);
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SearchInsert(new int[] { 2, 3, 5, 6, 8 }, 9);
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length-1;
            int closest = -1;
            while(end - start > 1)
            {
                int size = (end - start);
                int idx = start + (size / 2);
                if(nums[idx] == target)
                {
                    return idx;
                }
                else if (nums[idx] > target)
                {
                    end = idx;
                }
                else
                {
                    start = idx;
                }
            }

            if (nums[start] == target)
            {
                return start;
            }
            else if(nums[end] == target)
            {
                return end;
            }
            else if (nums[end] < target)
            {
                return end+1;
            }
            else if (nums[start] > target)
            {
                return start;
            }
            else if (nums[end] > target)
            {
                return end;
            }
            return closest;
        }
    }
}
