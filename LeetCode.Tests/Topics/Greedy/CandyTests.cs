namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class CandyTests
{
    [TestCase(new[] { 1, 0, 2 }, ExpectedResult = 5)]
    [TestCase(new[] { 1, 2, 2 }, ExpectedResult = 4)]
    [TestCase(new[] { 1, 2, 3 }, ExpectedResult = 6)]
    public int CandySolution(int[] ratings) =>
        Candy.CandySolution(ratings);
}
