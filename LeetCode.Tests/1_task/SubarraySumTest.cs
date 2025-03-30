namespace LeetCode.Tests;

public class SubarraySumTest
{
    [TestCase(new[] { 1, 1, 1 }, 2, ExpectedResult = 2)]
    [TestCase(new[] { 1, 2, 3 }, 3, ExpectedResult = 2)]
    public int FindMaxLength1Test(int[] array, int k)
    {
        return SubarraySum.SubarraySumPrefics(array, k);
    }
}
