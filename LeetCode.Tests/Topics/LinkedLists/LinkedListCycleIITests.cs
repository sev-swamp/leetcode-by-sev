namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class LinkedListCycleIITests
{
    [Test]
    public void DetectCycle_NoCycle()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.That(LinkedListCycleII.DetectCycle(head), Is.Null);
    }

    [Test]
    public void DetectCycle_WithCycle()
    {
        var node3 = new ListNode(3);
        var node2 = new ListNode(2);
        var node0 = new ListNode(0);
        var nodeNeg4 = new ListNode(-4);
        node3.next = node2;
        node2.next = node0;
        node0.next = nodeNeg4;
        nodeNeg4.next = node2; // cycle back to node2
        Assert.That(LinkedListCycleII.DetectCycle(node3), Is.SameAs(node2));
    }
}
