namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class CoinChangeTests
{
    [TestCase(new[] { 1, 5, 11 }, 15, ExpectedResult = 3)]
    [TestCase(new[] { 2 }, 3, ExpectedResult = -1)]
    [TestCase(new[] { 1 }, 0, ExpectedResult = 0)]
    public int CoinChangeSolution(int[] coins, int amount) =>
        CoinChange.CoinChangeSolution(coins, amount);
}
