namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class CanIWinTests
{
    [TestCase(10, 11, ExpectedResult = false)]
    [TestCase(10, 0, ExpectedResult = true)]
    [TestCase(10, 1, ExpectedResult = true)]
    public bool CanIWinSolution(int maxChoosableInteger, int desiredTotal) =>
        CanIWin.CanIWinSolution(maxChoosableInteger, desiredTotal);
}
