namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class SmallestSubtreeDeepestTests
{
    [Test]
    public void SubtreeWithAllDeepest_LeftDeeper()
    {
        var root = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(0), new TreeNode(8)));
        Assert.That(SmallestSubtreeDeepest.SubtreeWithAllDeepest(root).val, Is.EqualTo(2));
    }

    [Test]
    public void SubtreeWithAllDeepest_Root()
    {
        var root = new TreeNode(0, new TreeNode(1), new TreeNode(3, null!, new TreeNode(2)));
        Assert.That(SmallestSubtreeDeepest.SubtreeWithAllDeepest(root).val, Is.EqualTo(2));
    }
}
