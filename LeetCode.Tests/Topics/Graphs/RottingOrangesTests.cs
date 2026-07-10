namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class RottingOrangesTests
{
    [Test]
    public void OrangesRotting_TwoMinutes()
    {
        int[][] grid = [[2,1,1],[1,1,0],[0,1,1]];
        Assert.That(RottingOranges.OrangesRotting(grid), Is.EqualTo(4));
    }

    [Test]
    public void OrangesRotting_Impossible()
    {
        int[][] grid = [[2,1,1],[0,1,1],[1,0,1]];
        Assert.That(RottingOranges.OrangesRotting(grid), Is.EqualTo(-1));
    }

    [Test]
    public void OrangesRotting_NoFreshOranges()
    {
        int[][] grid = [[0,2]];
        Assert.That(RottingOranges.OrangesRotting(grid), Is.EqualTo(0));
    }
}
