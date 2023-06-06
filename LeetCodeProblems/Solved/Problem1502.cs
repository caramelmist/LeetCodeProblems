
namespace LeetCodeProblems.Solved
{
  public class Problem1502 : Solution
  {
    public void Run()
    {
      bool actual = CanMakeArithmeticProgression(new int[] { 3, 5, 1 });
      bool expected = true;
      Console.WriteLine("Outcome: {0} {1}", expected, actual);

      actual = CanMakeArithmeticProgression(new int[] { 1, 2, 4 });
      expected = false;
      Console.WriteLine("Outcome: {0} {1}", expected, actual);

      actual = CanMakeArithmeticProgression(new int[] { -13, -17, -8, -10, -20, 2, 3, -19, 2, -18, -5, 7, -12, 18, -17, 12, -1 });
      expected = false;
      Console.WriteLine("Outcome: {0} {1}", expected, actual);
    }

    public bool CanMakeArithmeticProgression(int[] arr)
    {
      Array.Sort(arr);

      for (int i = 0; i < arr.Length-2; i++)
      {
        if (arr[i+1] - arr[i] != arr[i+2] - arr[i+1])
        {
          return false;
        }
      }

      return true;
    }
  }
}
