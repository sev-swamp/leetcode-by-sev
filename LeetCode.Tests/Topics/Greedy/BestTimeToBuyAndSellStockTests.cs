namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class BestTimeToBuyAndSellStockTests
{
    [TestCase(new[] { 7, 1, 5, 3, 6, 4 }, ExpectedResult = 5)]
    [TestCase(new[] { 7, 6, 4, 3, 1 },    ExpectedResult = 0)]
    [TestCase(new[] { 1, 2 },             ExpectedResult = 1)]
    public int MaxProfit(int[] prices) =>
        BestTimeToBuyAndSellStock.MaxProfit(prices);
}
