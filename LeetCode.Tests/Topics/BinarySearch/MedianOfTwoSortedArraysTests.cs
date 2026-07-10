namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class MedianOfTwoSortedArraysTests
{
    [TestCase(new[] { 1, 3 }, new[] { 2 },    ExpectedResult = 2.0)]
    [TestCase(new[] { 1, 2 }, new[] { 3, 4 }, ExpectedResult = 2.5)]
    [TestCase(new int[] { },  new[] { 1 },    ExpectedResult = 1.0)]
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) =>
        MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
}
