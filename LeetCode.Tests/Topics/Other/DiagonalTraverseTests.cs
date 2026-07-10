namespace LeetCode.Tests;

[TestFixture]
[Category("Other")]
public class DiagonalTraverseTests
{
    [Test]
    public void FindDiagonalOrder_3x3()
    {
        int[][] mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        Assert.That(DiagonalTraverse.FindDiagonalOrder(mat), Is.EqualTo(new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }));
    }

    [Test]
    public void FindDiagonalOrder_2x2()
    {
        int[][] mat = [[1, 2], [3, 4]];

        Assert.That(DiagonalTraverse.FindDiagonalOrder(mat), Is.EqualTo(new[] { 1, 2, 3, 4 }));
    }

    [Test]
    public void FindDiagonalOrder_SingleElement()
    {
        int[][] mat = [[1]];

        Assert.That(DiagonalTraverse.FindDiagonalOrder(mat), Is.EqualTo(new[] { 1 }));
    }
}
