namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class HouseRobberTests
{
    [TestCase(new[] { 1, 2, 3, 1 }, ExpectedResult = 4)]
    [TestCase(new[] { 2, 7, 9, 3, 1 }, ExpectedResult = 12)]
    [TestCase(new[] { 1 }, ExpectedResult = 1)]
    public int Rob(int[] nums) => HouseRobber.Rob(nums);
}
