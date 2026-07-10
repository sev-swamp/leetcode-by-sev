namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class LongestIncreasingSubsequenceTests
{
    [TestCase(new[] { 10, 9, 2, 5, 3, 7, 101, 18 }, ExpectedResult = 4)]
    [TestCase(new[] { 0, 1, 0, 3, 2, 3 },           ExpectedResult = 4)]
    [TestCase(new[] { 7, 7, 7, 7, 7, 7, 7 },        ExpectedResult = 1)]
    public int LengthOfLIS(int[] nums) =>
        LongestIncreasingSubsequence.LengthOfLIS(nums);
}
