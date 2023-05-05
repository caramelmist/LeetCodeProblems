namespace LeetCodeProblemsTest.Solved;

public class Problem1046Test
{
    [Test]
    [TestCase(new int[] { 2, 7, 4, 1, 8, 1 }, 1)]
    [TestCase(new int[] { 1 }, 1)]
    [TestCase(new int[] { 3 }, 3)]
    [TestCase(new int[] { 10, 6 }, 4)]
    [TestCase(new int[] { 6, 10 }, 4)]
    [TestCase(new int[] { 10, 10 }, 0)]
    [TestCase(new int[] { 20, 70, 40, 10, 5, 80 }, 5)]
    [TestCase(new int[] { 3, 7, 2 }, 2)]
    public void Test(int[] values, int expected)
    {
        Problem1046 sut = new Problem1046();
        int actual = sut.LastStoneWeight(values);
        actual.Should().Be(expected);
    }
}
