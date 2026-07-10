namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class FloodFillTests
{
    [Test]
    public void FloodFillSolution_BasicCase()
    {
        int[][] img = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
        Assert.That(FloodFill.FloodFillSolution(img, 1, 1, 2), Is.EqualTo(new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 0 }, new[] { 2, 0, 1 } }));
    }

    [Test]
    public void FloodFillSolution_SameColor()
    {
        int[][] img = [[0, 0, 0], [0, 0, 0]];
        Assert.That(FloodFill.FloodFillSolution(img, 0, 0, 0), Is.EqualTo(new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }));
    }
}
