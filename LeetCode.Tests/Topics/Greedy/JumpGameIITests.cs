namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class JumpGameIITests
{
    [TestCase(new[] { 2, 3, 1, 1, 4 }, ExpectedResult = 2)]
    [TestCase(new[] { 2, 3, 0, 1, 4 }, ExpectedResult = 2)]
    [TestCase(new[] { 1 },             ExpectedResult = 0)]
    public int Jump(int[] nums) =>
        JumpGameII.Jump(nums);
}
