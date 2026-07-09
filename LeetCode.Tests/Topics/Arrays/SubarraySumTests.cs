namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class SubarraySumTests
{
    [TestCase(new[] { 1, 1, 1 }, 2, ExpectedResult = 2)]
    [TestCase(new[] { 1, 2, 3 }, 3, ExpectedResult = 2)]
    [TestCase(new[] { 1, 1 },    2, ExpectedResult = 1)]
    public int SubarraySumPrefics(int[] nums, int k) =>
        SubarraySum.SubarraySumPrefics(nums, k);
}
