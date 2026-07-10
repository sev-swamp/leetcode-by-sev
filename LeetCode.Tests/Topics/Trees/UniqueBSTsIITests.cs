namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class UniqueBSTsIITests
{
    [Test]
    public void GenerateTrees_N3()
    {
        Assert.That(UniqueBSTsII.GenerateTrees(3).Count, Is.EqualTo(5));
    }

    [Test]
    public void GenerateTrees_N1()
    {
        Assert.That(UniqueBSTsII.GenerateTrees(1).Count, Is.EqualTo(1));
    }
}
