namespace LeetCode.Tests;

[TestFixture]
[Category("Other")]
public class MergeSortedArrayTests
{
    [Test]
    public void Merge_BasicCase()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        MergeSortedArray.Merge(nums1, 3, [2, 5, 6], 3);

        Assert.That(nums1, Is.EqualTo(new[] { 1, 2, 2, 3, 5, 6 }));
    }

    [Test]
    public void Merge_EmptyNums2()
    {
        int[] nums1 = [1];
        MergeSortedArray.Merge(nums1, 1, [], 0);

        Assert.That(nums1, Is.EqualTo(new[] { 1 }));
    }

    [Test]
    public void Merge_EmptyNums1()
    {
        int[] nums1 = [0];
        MergeSortedArray.Merge(nums1, 0, [1], 1);

        Assert.That(nums1, Is.EqualTo(new[] { 1 }));
    }

    [Test]
    public void Merge_Interleaved()
    {
        int[] nums1 = [1, 3, 5, 0, 0, 0];
        MergeSortedArray.Merge(nums1, 3, [2, 4, 6], 3);

        Assert.That(nums1, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6 }));
    }
}
