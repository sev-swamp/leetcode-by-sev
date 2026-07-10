namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class MaxConsecutiveOnesIIITests
{
    [TestCase(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 },                      2, ExpectedResult = 6)]
    [TestCase(new[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, ExpectedResult = 10)]
    public int LongestOnes(int[] nums, int k) =>
        MaxConsecutiveOnesIII.LongestOnes(nums, k);
}
