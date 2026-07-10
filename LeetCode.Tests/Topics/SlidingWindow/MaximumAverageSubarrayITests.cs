namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class MaximumAverageSubarrayITests
{
    [TestCase(new[] { 1, 12, -5, -6, 50, 3 }, 4, ExpectedResult = 12.75)]
    [TestCase(new[] { 5 },                     1, ExpectedResult = 5.0)]
    [TestCase(new[] { -1, -12, -5 },           2, ExpectedResult = -6.5)]
    public double FindMaxAverage(int[] nums, int k) =>
        MaximumAverageSubarrayI.FindMaxAverage(nums, k);
}
