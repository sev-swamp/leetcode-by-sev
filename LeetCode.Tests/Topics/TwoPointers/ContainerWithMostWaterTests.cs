namespace LeetCode.Tests;

[TestFixture]
[Category("TwoPointers")]
public class ContainerWithMostWaterTests
{
    [TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, ExpectedResult = 49)]
    [TestCase(new[] { 1, 1 },                       ExpectedResult = 1)]
    public int MaxArea(int[] height) =>
        ContainerWithMostWater.MaxArea(height);
}
