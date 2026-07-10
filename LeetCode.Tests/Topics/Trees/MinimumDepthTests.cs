namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class MinimumDepthTests
{
    [Test]
    public void MinDepth_BalancedTree()
    {
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        Assert.That(MinimumDepth.MinDepth(root), Is.EqualTo(2));
    }

    [Test]
    public void MinDepth_LinearTree()
    {
        var root = new TreeNode(2, null!, new TreeNode(3, null!, new TreeNode(4, null!, new TreeNode(5, null!, new TreeNode(6)))));
        Assert.That(MinimumDepth.MinDepth(root), Is.EqualTo(5));
    }

    [Test]
    public void MinDepth_EmptyTree()
    {
        Assert.That(MinimumDepth.MinDepth(null!), Is.EqualTo(0));
    }
}
