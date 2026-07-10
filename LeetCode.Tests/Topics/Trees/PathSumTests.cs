namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class PathSumTests
{
    [Test]
    public void HasPathSum_PathExists()
    {
        var root = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)), null!), new TreeNode(8, new TreeNode(13), new TreeNode(4, null!, new TreeNode(1))));
        Assert.That(PathSum.HasPathSum(root, 22), Is.True);
    }

    [Test]
    public void HasPathSum_PathDoesNotExist()
    {
        var root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        Assert.That(PathSum.HasPathSum(root, 5), Is.False);
    }

    [Test]
    public void HasPathSum_EmptyTree()
    {
        Assert.That(PathSum.HasPathSum(null!, 0), Is.False);
    }
}
