namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class ReverseNodesInKGroupTests
{
    [Test]
    public void ReverseKGroup_K2()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(5)))));
        Assert.That(ReverseNodesInKGroup.ReverseKGroup(head, 2), Is.EqualTo(expected));
    }

    [Test]
    public void ReverseKGroup_K3()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(5)))));
        Assert.That(ReverseNodesInKGroup.ReverseKGroup(head, 3), Is.EqualTo(expected));
    }
}
