namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class MinAbsDiffBSTTests
{
    [Test]
    public void GetMinimumDifference_BasicBST()
    {
        var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6));
        Assert.That(MinAbsDiffBST.GetMinimumDifference(root), Is.EqualTo(1));
    }

    [Test]
    public void GetMinimumDifference_LargeValues()
    {
        var root = new TreeNode(1, null!, new TreeNode(3, new TreeNode(2), null!));
        Assert.That(MinAbsDiffBST.GetMinimumDifference(root), Is.EqualTo(1));
    }
}
