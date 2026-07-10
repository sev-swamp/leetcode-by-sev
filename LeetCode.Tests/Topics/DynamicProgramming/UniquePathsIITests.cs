namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class UniquePathsIITests
{
    [Test]
    public void UniquePathsWithObstacles_BasicCase()
    {
        int[][] grid = [[0,0,0],[0,1,0],[0,0,0]];
        Assert.That(UniquePathsII.UniquePathsWithObstacles(grid), Is.EqualTo(2));
    }

    [Test]
    public void UniquePathsWithObstacles_BlockedStart()
    {
        int[][] grid = [[0,1],[0,0]];
        Assert.That(UniquePathsII.UniquePathsWithObstacles(grid), Is.EqualTo(1));
    }

    [Test]
    public void UniquePathsWithObstacles_ObstacleAtStart()
    {
        int[][] grid = [[1,0]];
        Assert.That(UniquePathsII.UniquePathsWithObstacles(grid), Is.EqualTo(0));
    }
}
