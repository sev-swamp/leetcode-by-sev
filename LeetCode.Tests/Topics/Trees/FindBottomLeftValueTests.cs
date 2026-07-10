namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class FindBottomLeftValueTests
{
    [Test]
    public void FindBottomLeftValue_BasicTree()
    {
        var root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        Assert.That(FindBottomLeftValue.FindBottomLeftValueSolution(root), Is.EqualTo(1));
    }

    [Test]
    public void FindBottomLeftValue_DeepTree()
    {
        var root = new TreeNode(1, new TreeNode(2, new TreeNode(4), null!), new TreeNode(3, new TreeNode(5, new TreeNode(7), null!), new TreeNode(6)));
        Assert.That(FindBottomLeftValue.FindBottomLeftValueSolution(root), Is.EqualTo(7));
    }
}
