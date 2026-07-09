namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class ContiguousArrayTests
{
    [TestCase(new[] { 0, 1 },                      ExpectedResult = 2)]
    [TestCase(new[] { 0, 1, 0 },                   ExpectedResult = 2)]
    [TestCase(new[] { 0, 1, 1, 1, 1, 1, 0, 0, 0 }, ExpectedResult = 6)]
    public int FindMaxLength(int[] nums) =>
        ContiguousArray.FindMaxLength(nums);
}
