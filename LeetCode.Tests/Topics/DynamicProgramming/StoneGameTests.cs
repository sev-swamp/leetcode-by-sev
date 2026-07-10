namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class StoneGameTests
{
    [TestCase(new[] { 5, 3, 4, 5 }, ExpectedResult = true)]
    [TestCase(new[] { 3, 7, 2, 3 }, ExpectedResult = true)]
    public bool StoneGameSolution(int[] piles) =>
        StoneGame.StoneGameSolution(piles);
}
