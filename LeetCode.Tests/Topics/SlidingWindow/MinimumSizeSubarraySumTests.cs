namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class MinimumSizeSubarraySumTests
{
    [TestCase(7,  new[] { 2, 3, 1, 2, 4, 3 },          ExpectedResult = 2)]
    [TestCase(4,  new[] { 1, 4, 4 },                   ExpectedResult = 1)]
    [TestCase(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 },   ExpectedResult = 0)]
    [TestCase(15, new[] { 1, 2, 3, 4, 5 },             ExpectedResult = 5)]
    public int MinSubArrayLen(int target, int[] nums) =>
        MinimumSizeSubarraySum.MinSubArrayLen(target, nums);
}
