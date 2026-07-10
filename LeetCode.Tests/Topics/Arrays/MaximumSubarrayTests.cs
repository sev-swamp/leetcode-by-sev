namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class MaximumSubarrayTests
{
    [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, ExpectedResult = 6)]
    [TestCase(new[] { 1 },                              ExpectedResult = 1)]
    [TestCase(new[] { 5, 4, -1, 7, 8 },                ExpectedResult = 23)]
    public int MaxSubArray(int[] nums) =>
        MaximumSubarray.MaxSubArray(nums);
}
