namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class LowestCommonAncestorBSTTests
{
    [Test]
    public void LowestCommonAncestor_BasicBST()
    {
        var root = new TreeNode(6, new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7), new TreeNode(9)));
        var p = root.left; var q = root.right;
        Assert.That(LowestCommonAncestorBST.LowestCommonAncestor(root, p, q).val, Is.EqualTo(6));
    }
}
