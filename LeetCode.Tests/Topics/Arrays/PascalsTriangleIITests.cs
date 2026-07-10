namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class PascalsTriangleIITests
{
    [Test]
    public void GetRow_Row3()
    {
        Assert.That(PascalsTriangleII.GetRow(3), Is.EqualTo(new List<int> { 1, 3, 3, 1 }));
    }

    [Test]
    public void GetRow_Row0()
    {
        Assert.That(PascalsTriangleII.GetRow(0), Is.EqualTo(new List<int> { 1 }));
    }

    [Test]
    public void GetRow_Row1()
    {
        Assert.That(PascalsTriangleII.GetRow(1), Is.EqualTo(new List<int> { 1, 1 }));
    }
}
