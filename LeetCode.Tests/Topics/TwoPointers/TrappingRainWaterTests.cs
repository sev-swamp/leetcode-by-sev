namespace LeetCode.Tests;

[TestFixture]
[Category("TwoPointers")]
public class TrappingRainWaterTests
{
    [TestCase(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, ExpectedResult = 6)]
    [TestCase(new[] { 4, 2, 0, 3, 2, 5 },                   ExpectedResult = 9)]
    public int Trap(int[] height) =>
        TrappingRainWater.Trap(height);
}
