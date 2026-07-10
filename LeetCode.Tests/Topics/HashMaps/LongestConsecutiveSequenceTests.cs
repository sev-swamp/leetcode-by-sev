namespace LeetCode.Tests;

[TestFixture]
[Category("HashMaps")]
public class LongestConsecutiveSequenceTests
{
    [TestCase(new[] { 100, 4, 200, 1, 3, 2 },              ExpectedResult = 4)]
    [TestCase(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 },     ExpectedResult = 9)]
    [TestCase(new int[] { },                                ExpectedResult = 0)]
    public int LongestConsecutive(int[] nums) =>
        LongestConsecutiveSequence.LongestConsecutive(nums);
}
