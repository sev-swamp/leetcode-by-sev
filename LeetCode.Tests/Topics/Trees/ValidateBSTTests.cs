namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class ValidateBSTTests
{
    [Test]
    public void IsValidBST_ValidBST()
    {
        var root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        Assert.That(ValidateBST.IsValidBST(root), Is.True);
    }

    [Test]
    public void IsValidBST_InvalidBST()
    {
        var root = new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));
        Assert.That(ValidateBST.IsValidBST(root), Is.False);
    }

    [Test]
    public void IsValidBST_DuplicateValues()
    {
        var root = new TreeNode(2, new TreeNode(2), new TreeNode(2));
        Assert.That(ValidateBST.IsValidBST(root), Is.False);
    }
}
