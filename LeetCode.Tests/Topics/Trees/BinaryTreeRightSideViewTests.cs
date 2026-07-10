namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class BinaryTreeRightSideViewTests
{
    [Test]
    public void RightSideView_BasicTree()
    {
        Assert.That(BinaryTreeRightSideView.RightSideView(new TreeNode(1, new TreeNode(2, null!, new TreeNode(5)), new TreeNode(3, null!, new TreeNode(4)))), Is.EqualTo(new List<int> { 1, 3, 4 }));
    }

    [Test]
    public void RightSideView_EmptyTree()
    {
        Assert.That(BinaryTreeRightSideView.RightSideView(null!), Is.Empty);
    }
}
