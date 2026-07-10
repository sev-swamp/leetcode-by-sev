namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class HouseRobberIITests
{
    [TestCase(new[] { 2, 3, 2 }, ExpectedResult = 3)]
    [TestCase(new[] { 1, 2, 3, 1 }, ExpectedResult = 4)]
    [TestCase(new[] { 1, 2, 3 }, ExpectedResult = 3)]
    public int Rob2(int[] nums) => HouseRobberII.Rob2(nums);
}
