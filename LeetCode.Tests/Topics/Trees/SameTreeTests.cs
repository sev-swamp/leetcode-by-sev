namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class SameTreeTests
{
    [Test]
    public void IsSameTree_IdenticalTrees()
    {
        var p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        Assert.That(SameTree.IsSameTree(p, q), Is.True);
    }

    [Test]
    public void IsSameTree_DifferentStructure()
    {
        var p = new TreeNode(1, new TreeNode(2), null!);
        var q = new TreeNode(1, null!, new TreeNode(2));
        Assert.That(SameTree.IsSameTree(p, q), Is.False);
    }

    [Test]
    public void IsSameTree_DifferentValues()
    {
        var p = new TreeNode(1, new TreeNode(2), new TreeNode(1));
        var q = new TreeNode(1, new TreeNode(1), new TreeNode(2));
        Assert.That(SameTree.IsSameTree(p, q), Is.False);
    }
}
