using System;
namespace LeetCodeProblems.Solved
{
    public class Problem703 : Solution
    {
        public Problem703()
        {
        }

        public void Run()
        {
            KthLargest largest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
            int output = largest.Add(3);
            int expected = 4;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(5);
            expected = 5;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(10);
            expected = 5;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(9);
            expected = 8;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(4);
            expected = 8;
            Console.WriteLine($"{expected}: {output}");



            largest = new KthLargest(1, new int[] {});
            output = largest.Add(-3);
            expected = -3;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(-2);
            expected = -2;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(-4);
            expected = -2;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(0);
            expected = 0;
            Console.WriteLine($"{expected}: {output}");
            output = largest.Add(4);
            expected =4;
            Console.WriteLine($"{expected}: {output}");
        }
    }

    public class KthLargest
    {
        private readonly int _position;
        private List<int> _values = new List<int>();

        public KthLargest(int k, int[] nums)
        {
            _position = k;
            _values.AddRange(nums);
            _values.Sort();
        }

        public int Add(int val)
        {
            if(_values.Count == 0)
            {
                _values.Add(val);
                return val;
            }
            _values.Add(val);
            _values.Sort();

            return _values[_values.Count - _position];
        }
    }
}

