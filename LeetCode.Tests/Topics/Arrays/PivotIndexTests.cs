namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class PivotIndexTests
{
    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, ExpectedResult = 3)]
    [TestCase(new[] { 1, 2, 3 },           ExpectedResult = -1)]
    [TestCase(new[] { 2, 1, -1 },          ExpectedResult = 0)]
    public int PivotsIndex(int[] nums) =>
        PivotIndex.PivotsIndex(nums);
}
