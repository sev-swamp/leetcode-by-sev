namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class MaxDepthBinaryTreeTests
{
    [Test]
    public void MaxDepth_BasicTree()
    {
        Assert.That(MaxDepthBinaryTree.MaxDepth(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))), Is.EqualTo(3));
    }

    [Test]
    public void MaxDepth_NullTree()
    {
        Assert.That(MaxDepthBinaryTree.MaxDepth(null!), Is.EqualTo(0));
    }

    [Test]
    public void MaxDepth_SingleNode()
    {
        Assert.That(MaxDepthBinaryTree.MaxDepth(new TreeNode(1)), Is.EqualTo(1));
    }
}
