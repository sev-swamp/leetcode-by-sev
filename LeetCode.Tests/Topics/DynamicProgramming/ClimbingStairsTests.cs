namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class ClimbingStairsTests
{
    [TestCase(1, ExpectedResult = 1)]
    [TestCase(2, ExpectedResult = 2)]
    [TestCase(3, ExpectedResult = 3)]
    [TestCase(5, ExpectedResult = 8)]
    public int ClimbStairs(int n) =>
        ClimbingStairs.ClimbStairs(n);
}
