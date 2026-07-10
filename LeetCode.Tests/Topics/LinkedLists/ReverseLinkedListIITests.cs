namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class ReverseLinkedListIITests
{
    [Test]
    public void ReverseBetween_MiddleSection()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5)))));
        Assert.That(ReverseLinkedListII.ReverseBetween(head, 2, 4), Is.EqualTo(expected));
    }

    [Test]
    public void ReverseBetween_WholeList()
    {
        var head = new ListNode(3, new ListNode(5));
        var expected = new ListNode(5, new ListNode(3));
        Assert.That(ReverseLinkedListII.ReverseBetween(head, 1, 2), Is.EqualTo(expected));
    }
}
