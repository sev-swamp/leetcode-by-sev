namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class MinimumPathSumTests
{
    [Test]
    public void MinPathSum_BasicCase()
    {
        Assert.That(MinimumPathSum.MinPathSum([[1, 3, 1], [1, 5, 1], [4, 2, 1]]), Is.EqualTo(7));
    }

    [Test]
    public void MinPathSum_SingleRow()
    {
        Assert.That(MinimumPathSum.MinPathSum([[1, 2, 3]]), Is.EqualTo(6));
    }
}
