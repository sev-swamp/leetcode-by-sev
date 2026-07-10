namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class PerfectSquaresTests
{
    [TestCase(12, ExpectedResult = 3)]
    [TestCase(13, ExpectedResult = 2)]
    [TestCase(1,  ExpectedResult = 1)]
    [TestCase(4,  ExpectedResult = 1)]
    public int NumSquares(int n) =>
        PerfectSquares.NumSquares(n);
}
