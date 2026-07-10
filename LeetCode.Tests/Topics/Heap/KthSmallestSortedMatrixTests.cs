namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class KthSmallestSortedMatrixTests
{
    [Test]
    public void KthSmallest_BasicMatrix()
    {
        int[][] matrix = [[1,5,9],[10,11,13],[12,13,15]];
        Assert.That(KthSmallestSortedMatrix.KthSmallest(matrix, 8), Is.EqualTo(13));
    }

    [Test]
    public void KthSmallest_SingleElement()
    {
        int[][] matrix = [[-5]];
        Assert.That(KthSmallestSortedMatrix.KthSmallest(matrix, 1), Is.EqualTo(-5));
    }
}
