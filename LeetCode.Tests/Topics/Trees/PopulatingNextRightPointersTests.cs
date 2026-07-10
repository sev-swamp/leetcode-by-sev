namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class PopulatingNextRightPointersTests
{
    [Test]
    public void Connect_PerfectBinaryTree()
    {
        var root = new Node(1, new Node(2, new Node(4), new Node(5)), new Node(3, new Node(6), new Node(7)));
        var connected = PopulatingNextRightPointers.Connect(root);
        Assert.That(connected.left.next, Is.SameAs(connected.right));
        Assert.That(connected.right.next, Is.Null);
        Assert.That(connected.left.left.next, Is.SameAs(connected.left.right));
        Assert.That(connected.left.right.next, Is.SameAs(connected.right.left));
    }

    [Test]
    public void Connect_NullRoot()
    {
        Assert.That(PopulatingNextRightPointers.Connect(null!), Is.Null);
    }
}
