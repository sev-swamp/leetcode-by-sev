namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class SmallestDivisorGivenThresholdTests
{
    [TestCase(new[] { 1, 2, 5, 9 },      6,  ExpectedResult = 5)]
    [TestCase(new[] { 44, 22, 33, 11, 1 }, 5, ExpectedResult = 44)]
    [TestCase(new[] { 2, 3, 5, 7, 11 },  11, ExpectedResult = 3)]
    public int SmallestDivisor(int[] nums, int threshold) =>
        SmallestDivisorGivenThreshold.SmallestDivisor(nums, threshold);
}
