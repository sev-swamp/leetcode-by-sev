namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class PathSumIITests
{
    [Test]
    public void PathSumPaths_MultiplePaths()
    {
        var root = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)), null!), new TreeNode(8, new TreeNode(13), new TreeNode(4, new TreeNode(5), new TreeNode(1))));
        var result = PathSumII.PathSumPaths(root, 22);
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 5, 4, 11, 2 }));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 5, 8, 4, 5 }));
    }

    [Test]
    public void PathSumPaths_NoPath()
    {
        var root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        Assert.That(PathSumII.PathSumPaths(root, 5), Is.Empty);
    }
}
