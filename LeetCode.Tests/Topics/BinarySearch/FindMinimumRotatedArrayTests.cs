namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class FindMinimumRotatedArrayTests
{
    [TestCase(new[] { 3, 4, 5, 1, 2 },       ExpectedResult = 1)]
    [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, ExpectedResult = 0)]
    [TestCase(new[] { 11, 13, 15, 17 },       ExpectedResult = 11)]
    [TestCase(new[] { 2, 1 },                 ExpectedResult = 1)]
    public int FindMin(int[] nums) =>
        FindMinimumRotatedArray.FindMin(nums);
}
