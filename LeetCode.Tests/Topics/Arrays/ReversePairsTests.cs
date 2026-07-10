namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class ReversePairsTests
{
    [TestCase(new[] { 1, 3, 2, 3, 1 }, ExpectedResult = 2)]
    [TestCase(new[] { 2, 4, 3, 5, 1 }, ExpectedResult = 3)]
    [TestCase(new int[] { },            ExpectedResult = 0)]
    public int ReversePairsSolution(int[] nums) =>
        ReversePairs.ReversePairsSolution(nums);
}
