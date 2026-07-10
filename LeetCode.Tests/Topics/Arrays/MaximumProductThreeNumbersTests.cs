namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class MaximumProductThreeNumbersTests
{
    [TestCase(new[] { 1, 2, 3 },            ExpectedResult = 6)]
    [TestCase(new[] { 1, 2, 3, 4 },         ExpectedResult = 24)]
    [TestCase(new[] { -4, -3, -2, -1, 60 }, ExpectedResult = 720)]
    public int MaximumProduct(int[] nums) =>
        MaximumProductThreeNumbers.MaximumProduct(nums);
}
