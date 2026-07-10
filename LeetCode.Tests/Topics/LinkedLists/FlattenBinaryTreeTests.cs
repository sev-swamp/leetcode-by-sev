namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class FlattenBinaryTreeTests
{
    [Test]
    public void Flatten_BasicTree()
    {
        var root = new TreeNode(1,
            new TreeNode(2, new TreeNode(3), new TreeNode(4)),
            new TreeNode(5, null!, new TreeNode(6)));
        FlattenBinaryTree.Flatten(root);
        // preorder: 1->2->3->4->5->6
        int[] expected = [1, 2, 3, 4, 5, 6];
        var vals = new List<int>();
        var cur = root;
        while (cur != null) { vals.Add(cur.val); cur = cur.right; }
        Assert.That(vals, Is.EqualTo(expected));
    }

    [Test]
    public void Flatten_EmptyTree()
    {
        FlattenBinaryTree.Flatten(null!); // should not throw
    }
}
