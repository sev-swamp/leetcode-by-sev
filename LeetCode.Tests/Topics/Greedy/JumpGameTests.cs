namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class JumpGameTests
{
    [TestCase(new[] { 2, 3, 1, 1, 4 }, ExpectedResult = true)]
    [TestCase(new[] { 3, 2, 1, 0, 4 }, ExpectedResult = false)]
    [TestCase(new[] { 0 },             ExpectedResult = true)]
    public bool CanJump(int[] nums) =>
        JumpGame.CanJump(nums);
}
