namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class LastStoneWeightTests
{
    [TestCase(new[] { 2, 7, 4, 1, 8, 1 }, ExpectedResult = 1)]
    [TestCase(new[] { 1 },                 ExpectedResult = 1)]
    public int LastStoneWeightSolution(int[] stones) =>
        LastStoneWeight.LastStoneWeightSolution(stones);
}
