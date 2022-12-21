namespace LeetCodeProblems.Solved
{
    public class Problem841 : Solution
    {
        public void Run()
        {
            bool actual = CanVisitAllRooms(new int[][] { new int[] { 1 }, new int[] { 2 }, new int[] { 3 }, new int[] { } });
            bool expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = CanVisitAllRooms(new int[][] { new int[] { 1, 3 }, new int[] { 3, 0, 1 }, new int[] { 2 }, new int[] { 0 } });
            expected = false;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = CanVisitAllRooms(new int[][] { new int[] { 1, 3 }, new int[] { 1, 4 }, new int[] { 2, 3, 4, 1 }, new int[] { }, new int[] { 4, 3, 2 } });
            expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);
        }

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool[] keys = new bool[rooms.Count];
            keys[0] = true;

            for (int i = 0; i < rooms.Count; i++)
            {
                if (keys[i])
                {
                    for (int j = 0; j < rooms[i].Count; j++)
                    {
                        int key = rooms[i][j];
                        if (keys[key])
                        {
                            continue;
                        }
                        keys[key] = true;
                        i = 0;
                    }
                }
            }

            return keys.All((a) => a == true);
        }
    }
}
