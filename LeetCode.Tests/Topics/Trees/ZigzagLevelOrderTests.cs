namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class ZigzagLevelOrderTests
{
    [Test]
    public void ZigzagLevelOrder_BasicTree()
    {
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        var result = ZigzagLevelOrder.ZigzagLevelOrderSolution(root);
        Assert.That(result[0], Is.EqualTo(new List<int> { 3 }));
        Assert.That(result[1], Is.EqualTo(new List<int> { 20, 9 }));
        Assert.That(result[2], Is.EqualTo(new List<int> { 15, 7 }));
    }
}
