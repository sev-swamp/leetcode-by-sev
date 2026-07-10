namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class NumberOfIslandsTests
{
    [Test]
    public void NumIslands_ThreeIslands()
    {
        char[][] grid = [['1','1','0','0','0'],['1','1','0','0','0'],['0','0','1','0','0'],['0','0','0','1','1']];
        Assert.That(NumberOfIslands.NumIslands(grid), Is.EqualTo(3));
    }

    [Test]
    public void NumIslands_OneIsland()
    {
        char[][] grid = [['1','1','1','1','0'],['1','1','0','1','0'],['1','1','0','0','0'],['0','0','0','0','0']];
        Assert.That(NumberOfIslands.NumIslands(grid), Is.EqualTo(1));
    }
}
