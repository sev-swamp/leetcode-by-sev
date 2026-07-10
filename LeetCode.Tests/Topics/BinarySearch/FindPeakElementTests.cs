namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class FindPeakElementTests
{
    [Test]
    public void FindPeak_SinglePeak()
    {
        int[] nums = [1, 2, 3, 1];
        int idx = FindPeakElement.FindPeak(nums);

        Assert.That(IsValidPeak(nums, idx), Is.True, $"Index {idx} is not a valid peak");
    }

    [Test]
    public void FindPeak_MultiplePeaks()
    {
        int[] nums = [1, 2, 1, 3, 5, 6, 4];
        int idx = FindPeakElement.FindPeak(nums);

        Assert.That(IsValidPeak(nums, idx), Is.True, $"Index {idx} is not a valid peak");
    }

    [Test]
    public void FindPeak_SingleElement()
    {
        int[] nums = [1];
        int idx = FindPeakElement.FindPeak(nums);

        Assert.That(IsValidPeak(nums, idx), Is.True, $"Index {idx} is not a valid peak");
    }

    private static bool IsValidPeak(int[] nums, int idx)
    {
        if (idx < 0 || idx >= nums.Length) return false;
        bool leftOk  = idx == 0              || nums[idx] > nums[idx - 1];
        bool rightOk = idx == nums.Length - 1 || nums[idx] > nums[idx + 1];
        return leftOk && rightOk;
    }
}
