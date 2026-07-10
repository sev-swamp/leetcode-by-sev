namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class LargestRectangleHistogramTests
{
    [TestCase(new[] { 2, 1, 5, 6, 2, 3 }, ExpectedResult = 10)]
    [TestCase(new[] { 2, 4 }, ExpectedResult = 4)]
    [TestCase(new[] { 1 }, ExpectedResult = 1)]
    public int LargestRectangleArea(int[] heights) =>
        LargestRectangleHistogram.LargestRectangleArea(heights);
}
