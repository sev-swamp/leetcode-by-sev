namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class BalancedBinaryTreeTests
{
    [Test]
    public void IsBalanced_BalancedTree()
    {
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        Assert.That(BalancedBinaryTree.IsBalanced(root), Is.True);
    }

    [Test]
    public void IsBalanced_UnbalancedTree()
    {
        var root = new TreeNode(1, new TreeNode(2, new TreeNode(3, new TreeNode(4), null!), null!), null!);
        Assert.That(BalancedBinaryTree.IsBalanced(root), Is.False);
    }
}
