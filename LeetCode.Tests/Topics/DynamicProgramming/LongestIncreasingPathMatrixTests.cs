namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class LongestIncreasingPathMatrixTests
{
    [Test]
    public void LongestIncreasingPath_BasicMatrix()
    {
        int[][] matrix = [[9,9,4],[6,6,8],[2,1,1]];
        Assert.That(LongestIncreasingPathMatrix.LongestIncreasingPath(matrix), Is.EqualTo(4));
    }

    [Test]
    public void LongestIncreasingPath_AnotherMatrix()
    {
        int[][] matrix = [[3,4,5],[3,2,6],[2,2,1]];
        Assert.That(LongestIncreasingPathMatrix.LongestIncreasingPath(matrix), Is.EqualTo(4));
    }

    [Test]
    public void LongestIncreasingPath_SingleElement()
    {
        int[][] matrix = [[1]];
        Assert.That(LongestIncreasingPathMatrix.LongestIncreasingPath(matrix), Is.EqualTo(1));
    }
}
