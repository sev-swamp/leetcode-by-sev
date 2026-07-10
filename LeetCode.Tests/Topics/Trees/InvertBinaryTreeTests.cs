namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class InvertBinaryTreeTests
{
    [Test]
    public void InvertTree_BasicTree()
    {
        var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        var inverted = InvertBinaryTree.InvertTree(root);
        Assert.That(inverted.val, Is.EqualTo(4));
        Assert.That(inverted.left.val, Is.EqualTo(7));
        Assert.That(inverted.right.val, Is.EqualTo(2));
    }

    [Test]
    public void InvertTree_EmptyTree()
    {
        Assert.That(InvertBinaryTree.InvertTree(null!), Is.Null);
    }
}
