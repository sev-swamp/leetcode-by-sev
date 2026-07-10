namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class MinimumAbsoluteSumDifferenceTests
{
    [TestCase(new[] { 1, 7, 5 },        new[] { 2, 3, 5 },        ExpectedResult = 3)]
    [TestCase(new[] { 2, 4, 6, 8, 10 }, new[] { 2, 4, 6, 8, 10 }, ExpectedResult = 0)]
    [TestCase(new[] { 1, 10, 4, 2 },    new[] { 9, 3, 2, 7 },     ExpectedResult = 20)]
    public int MinAbsoluteSumDiff(int[] nums1, int[] nums2) =>
        MinimumAbsoluteSumDifference.MinAbsoluteSumDiff(nums1, nums2);
}
