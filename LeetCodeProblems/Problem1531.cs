using LeetCodeProblems;
using System;

public class Problem1531: Solution
{
	public Problem1531()
	{
	}

    public void Run()
    {
        int actual = GetLengthOfOptimalCompression("abaac", 2);
        int expected = 3;
        Console.WriteLine("Outcome: {0} {1}", expected, actual);

        actual = GetLengthOfOptimalCompression("aaaaaaaaaaa", 2);
        expected = 0;
        Console.WriteLine("Outcome: {0} {1}", expected, actual);

        actual = GetLengthOfOptimalCompression("aaaaaaaaaaa", 0);
        expected = 0;
        Console.WriteLine("Outcome: {0} {1}", expected, actual);
    }

    public int GetLengthOfOptimalCompression(string s, int k)
    {

        return 0;
    }
}
