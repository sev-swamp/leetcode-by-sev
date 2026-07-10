namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class ReverseLinkedListTests
{
    [Test]
    public void ReverseList_MultipleNodes()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));
        Assert.That(ReverseLinkedList.ReverseList(head), Is.EqualTo(expected));
    }

    [Test]
    public void ReverseList_SingleNode()
    {
        Assert.That(ReverseLinkedList.ReverseList(new ListNode(1)), Is.EqualTo(new ListNode(1)));
    }

    [Test]
    public void ReverseList_EmptyList()
    {
        Assert.That(ReverseLinkedList.ReverseList(null!), Is.Null);
    }
}
