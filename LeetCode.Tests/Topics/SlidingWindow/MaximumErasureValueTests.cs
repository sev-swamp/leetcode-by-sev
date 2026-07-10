namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class MaximumErasureValueTests
{
    [TestCase(new[] { 4, 2, 4, 5, 6 },         ExpectedResult = 17)]
    [TestCase(new[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 }, ExpectedResult = 8)]
    public int MaximumUniqueSubarray(int[] nums) =>
        MaximumErasureValue.MaximumUniqueSubarray(nums);
}
