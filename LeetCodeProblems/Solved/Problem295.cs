using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem295 : Solution
    {
        public void Run()
        {
            MedianFinder medianFinder = new MedianFinder();
            medianFinder.AddNum(1);    // arr = [1]
            medianFinder.AddNum(2);    // arr = [1, 2]
            double actual = medianFinder.FindMedian(); // return 1.5 (i.e., (1 + 2) / 2)
            double expected = 1.5;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(3);    // arr[1, 2, 3]
            actual = medianFinder.FindMedian(); // return 2.0
            expected = 2.0;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);

            Console.WriteLine("----------------------------------------------------");

            medianFinder = new MedianFinder();
            medianFinder.AddNum(-1);
            actual = medianFinder.FindMedian();
            expected = -1;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(-2);
            actual = medianFinder.FindMedian();
            expected = -1.5;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(-3);
            actual = medianFinder.FindMedian();
            expected = -2.0;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(-4);
            actual = medianFinder.FindMedian();
            expected = -2.5;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(-5);
            actual = medianFinder.FindMedian();
            expected = -3.0;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);

            Console.WriteLine("----------------------------------------------------");

            medianFinder = new MedianFinder();
            medianFinder.AddNum(40);
            actual = medianFinder.FindMedian();
            expected = 40;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(12);
            actual = medianFinder.FindMedian();
            expected = 26;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(16);
            actual = medianFinder.FindMedian();
            expected = 16;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(14);
            actual = medianFinder.FindMedian();
            expected = 15;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
            medianFinder.AddNum(35);
            actual = medianFinder.FindMedian();
            expected = 16;
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
        }
    }

    public class MedianFinder
    {
        private List<int> values = new List<int>();

        public MedianFinder()
        {
        }

        public void AddNum(int num)
        {
            if (values.Count == 0 || num >= values[values.Count - 1])
            {
                values.Add(num);
            }
            else if (num <= values[0])
            {
                values.Insert(0, num);
            }
            else
            {
                for (int i = 1; i < values.Count; i++)
                {
                    if (num <= values[i])
                    {
                        values.Insert(i, num);
                        break;
                    }
                    else if (num >= values[values.Count - (i + 1)])
                    {
                        values.Insert(values.Count - i, num);
                        break;
                    }
                }
            }
        }

        public double FindMedian()
        {
            int c = values.Count;
            bool odd = c % 2 == 1;

            int pos = c / 2;

            if (odd)
            {
                return values.ElementAt(pos);
            }
            else
            {
                int v1 = values.ElementAt(pos);
                int v2 = values.ElementAt(pos - 1);
                return (v1 + v2) / 2.0d;
            }
        }
    }
}
