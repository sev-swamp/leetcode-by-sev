namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class AllNodesDistanceKTests
{
    [Test]
    public void DistanceK_BasicCase()
    {
        var target = new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4)));
        var root = new TreeNode(3, target, new TreeNode(1, new TreeNode(0), new TreeNode(8)));
        var result = AllNodesDistanceK.DistanceK(root, target, 2);
        Assert.That(result.OrderBy(x => x).ToList(), Is.EqualTo(new List<int> { 1, 4, 7 }));
    }
}
