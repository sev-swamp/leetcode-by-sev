namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class BinaryTreePathsTests
{
    [Test]
    public void BinaryTreePathsSolution_BasicTree()
    {
        var root = new TreeNode(1, new TreeNode(2, null!, new TreeNode(5)), new TreeNode(3));
        var result = BinaryTreePaths.BinaryTreePathsSolution(root);
        Assert.That(result, Has.Member("1->2->5"));
        Assert.That(result, Has.Member("1->3"));
    }

    [Test]
    public void BinaryTreePathsSolution_SingleNode()
    {
        Assert.That(BinaryTreePaths.BinaryTreePathsSolution(new TreeNode(1)), Is.EqualTo(new List<string> { "1" }));
    }
}
