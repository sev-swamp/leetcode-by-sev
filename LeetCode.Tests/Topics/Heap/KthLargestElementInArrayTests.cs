namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class KthLargestElementInArrayTests
{
    [TestCase(new[] { 3, 2, 1, 5, 6, 4 }, 2, ExpectedResult = 5)]
    [TestCase(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, ExpectedResult = 4)]
    public int FindKthLargest(int[] nums, int k) =>
        KthLargestElementInArray.FindKthLargest(nums, k);
}
