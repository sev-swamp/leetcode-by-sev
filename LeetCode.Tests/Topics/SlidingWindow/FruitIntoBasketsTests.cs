namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class FruitIntoBasketsTests
{
    [TestCase(new[] { 1, 2, 1 },       ExpectedResult = 3)]
    [TestCase(new[] { 0, 1, 2, 2 },    ExpectedResult = 3)]
    [TestCase(new[] { 1, 2, 3, 2, 2 }, ExpectedResult = 4)]
    [TestCase(new[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }, ExpectedResult = 5)]
    public int TotalFruit(int[] fruits) =>
        FruitIntoBaskets.TotalFruit(fruits);
}
