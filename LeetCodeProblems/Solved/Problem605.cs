using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem605 : Solution
    {
        public void Run()
        {
            bool actual = CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1);
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 1 }, 2);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanPlaceFlowers(new int[] { 0, 0, 1, 0, 1 }, 1);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanPlaceFlowers(new int[] { 1, 0, 1, 0, 0 }, 1);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanPlaceFlowers(new int[] { 0, 0, 0, 0, 0, 1, 0, 0 }, 0);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }


        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int placed = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i - 1] == 0) &&
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    placed++;
                    flowerbed[i] = 1;
                }
                if (n <= placed)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
