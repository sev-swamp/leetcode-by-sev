namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class KthSmallestBSTTests
{
    [Test]
    public void KthSmallest_ThirdSmallest()
    {
        var root = new TreeNode(3, new TreeNode(1, null!, new TreeNode(2)), new TreeNode(4));
        Assert.That(KthSmallestBST.KthSmallest(root, 1), Is.EqualTo(1));
    }

    [Test]
    public void KthSmallest_LargerK()
    {
        var root = new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1), null!), new TreeNode(4)), new TreeNode(6));
        Assert.That(KthSmallestBST.KthSmallest(root, 3), Is.EqualTo(3));
    }
}
