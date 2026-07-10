namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class ConstructBinaryTreeTests
{
    [Test]
    public void BuildTree_BasicCase()
    {
        var root = ConstructBinaryTree.BuildTree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7]);
        Assert.That(root.val, Is.EqualTo(3));
        Assert.That(root.left.val, Is.EqualTo(9));
        Assert.That(root.right.val, Is.EqualTo(20));
    }

    [Test]
    public void BuildTree_SingleNode()
    {
        var root = ConstructBinaryTree.BuildTree([-1], [-1]);
        Assert.That(root.val, Is.EqualTo(-1));
    }
}
