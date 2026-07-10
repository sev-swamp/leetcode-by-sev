namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class RemoveNthNodeTests
{
    [Test]
    public void RemoveNthFromEnd_RemovesCorrectNode()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));
        Assert.That(RemoveNthNode.RemoveNthFromEnd(head, 2), Is.EqualTo(expected));
    }

    [Test]
    public void RemoveNthFromEnd_SingleNode()
    {
        Assert.That(RemoveNthNode.RemoveNthFromEnd(new ListNode(1), 1), Is.Null);
    }

    [Test]
    public void RemoveNthFromEnd_RemovesHead()
    {
        var head = new ListNode(1, new ListNode(2));
        var expected = new ListNode(2);
        Assert.That(RemoveNthNode.RemoveNthFromEnd(head, 2), Is.EqualTo(expected));
    }
}
