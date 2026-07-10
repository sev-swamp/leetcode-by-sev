namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class LevelOrderTraversalIITests
{
    [Test]
    public void LevelOrderBottom_BasicTree()
    {
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        var result = LevelOrderTraversalII.LevelOrderBottom(root);
        Assert.That(result[0], Is.EqualTo(new List<int> { 15, 7 }));
        Assert.That(result[1], Is.EqualTo(new List<int> { 9, 20 }));
        Assert.That(result[2], Is.EqualTo(new List<int> { 3 }));
    }
}
