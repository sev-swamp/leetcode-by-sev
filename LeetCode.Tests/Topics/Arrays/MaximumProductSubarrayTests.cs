namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class MaximumProductSubarrayTests
{
    [TestCase(new[] { 2, 3, -2, 4 },  ExpectedResult = 6)]
    [TestCase(new[] { -2, 0, -1 },    ExpectedResult = 0)]
    [TestCase(new[] { -2, 3, -4 },    ExpectedResult = 24)]
    public int MaxProduct(int[] nums) =>
        MaximumProductSubarray.MaxProduct(nums);
}
