namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class FindDuplicateSubtreesTests
{
    [Test]
    public void FindDuplicateSubtreesSolution_HasDuplicates()
    {
        var root = new TreeNode(1, new TreeNode(2, new TreeNode(4), null!), new TreeNode(3, new TreeNode(2, new TreeNode(4), null!), new TreeNode(4)));
        var result = FindDuplicateSubtrees.FindDuplicateSubtreesSolution(root);
        // should contain roots of duplicated subtrees (values 2 and 4)
        Assert.That(result.Count, Is.EqualTo(2));
    }
}
