using System;
namespace LeetCodeProblems
{
    public class Problem2007 : Solution
    {
        public Problem2007()
        {
        }

        public void Run()
        {
            int[] actual = FindOriginalArray(new int[] { 1, 3, 4, 2, 6, 8 });
            int[] expected = new int[] {1, 3, 4};
            Console.WriteLine("Outcome: {0} {1}", expected.Length, actual.Length);

            actual = FindOriginalArray(new int[] { 1, 3, 2, 4, 4, 2, 6, 8 });
            expected = new int[] { 1, 3, 4, 2 };
            Console.WriteLine("Outcome: {0} {1}", expected.Length, actual.Length);

            actual = FindOriginalArray(new int[] { 6, 3, 0, 1});
            expected = Array.Empty<int>();
            Console.WriteLine("Outcome: {0} {1}", expected.Length, actual.Length);

            actual = FindOriginalArray(new int[] { 1 });
            expected = Array.Empty<int>();
            Console.WriteLine("Outcome: {0} {1}", expected.Length, actual.Length);

            actual = FindOriginalArray(new int[] { 4, 4, 16, 20, 8, 8, 2, 10 });
            expected = new int[] { 2, 4, 8, 10};
            Console.WriteLine("Outcome: {0} {1}", expected.Length, actual.Length);
        }

        public int[] FindOriginalArray(int[] changed)
        {
            int len = changed.Length;
            if (len <= 1 || len % 2 == 1)
            {
                // must have an even number of elements and not 0
                return Array.Empty<int>();
            }

            List<int> cList = changed.ToList();
            List<int> orginal = new List<int>();

            cList.Sort();

            while(cList.Count > 0)
            {
                int v = cList[0];
                orginal.Add(v);
                cList.Remove(v);

                if (!cList.Remove(v * 2))
                {
                    return Array.Empty<int>();
                }
            }

            return orginal.ToArray();
        }
    }
}

