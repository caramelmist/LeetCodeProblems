using System;
namespace LeetCodeProblems
{
    public class Problem393 : Solution
    {
        public Problem393()
        {
        }

        public void Run()
        {
            bool actual = ValidUtf8(new int[] { 197, 130, 1 });
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ValidUtf8(new int[] { 235, 140, 4 });
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ValidUtf8(new int[] { 255 });
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ValidUtf8(new int[] { 16 });
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ValidUtf8(new int[] { 127 });
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ValidUtf8(new int[] { 128 });
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool ValidUtf8(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 128)
                {
                    continue;
                }

                string binary = Convert.ToString(data[i], 2).PadLeft(8, '0');

                int index = binary.IndexOf("10");
                if (index <= 0 || index > 3)
                {
                    return false;
                }

                for (int j = 0; j < index; j++)
                {
                    i++;
                    if (i >= data.Length)
                    {
                        return false;
                    }

                    binary = Convert.ToString(data[i], 2).PadLeft(8, '0');
                    if (!binary.StartsWith("10"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

