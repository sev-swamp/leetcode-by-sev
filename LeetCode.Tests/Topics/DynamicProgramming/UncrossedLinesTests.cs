namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class UncrossedLinesTests
{
    [TestCase(new[] { 1, 4, 2 }, new[] { 1, 2, 4 }, ExpectedResult = 2)]
    [TestCase(new[] { 2, 5, 1, 2, 5 }, new[] { 10, 5, 2, 1, 5, 2 }, ExpectedResult = 3)]
    [TestCase(new[] { 1, 3, 7, 1, 7, 5 }, new[] { 1, 9, 2, 5, 1 }, ExpectedResult = 2)]
    public int MaxUncrossedLines(int[] nums1, int[] nums2) =>
        UncrossedLines.MaxUncrossedLines(nums1, nums2);
}
