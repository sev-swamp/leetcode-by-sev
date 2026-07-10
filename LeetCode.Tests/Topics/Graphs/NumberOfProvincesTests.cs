namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class NumberOfProvincesTests
{
    [Test]
    public void FindCircleNum_TwoProvinces()
    {
        int[][] matrix = [[1,1,0],[1,1,0],[0,0,1]];
        Assert.That(NumberOfProvinces.FindCircleNum(matrix), Is.EqualTo(2));
    }

    [Test]
    public void FindCircleNum_ThreeProvinces()
    {
        int[][] matrix = [[1,0,0],[0,1,0],[0,0,1]];
        Assert.That(NumberOfProvinces.FindCircleNum(matrix), Is.EqualTo(3));
    }
}
