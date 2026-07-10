namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class SymmetricTreeTests
{
    [Test]
    public void IsSymmetric_SymmetricTree()
    {
        var root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
        Assert.That(SymmetricTree.IsSymmetric(root), Is.True);
    }

    [Test]
    public void IsSymmetric_AsymmetricTree()
    {
        var root = new TreeNode(1, new TreeNode(2, null!, new TreeNode(3)), new TreeNode(2, null!, new TreeNode(3)));
        Assert.That(SymmetricTree.IsSymmetric(root), Is.False);
    }
}
