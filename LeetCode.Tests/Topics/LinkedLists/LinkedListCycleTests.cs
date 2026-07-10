namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class LinkedListCycleTests
{
    [Test]
    public void HasCycle_NoCycle()
    {
        Assert.That(LinkedListCycle.HasCycle(new ListNode(1, new ListNode(2, new ListNode(3)))), Is.False);
    }

    [Test]
    public void HasCycle_WithCycle()
    {
        var n3 = new ListNode(3); var n2 = new ListNode(2); var n0 = new ListNode(0); var n4 = new ListNode(-4);
        n3.next = n2; n2.next = n0; n0.next = n4; n4.next = n2;
        Assert.That(LinkedListCycle.HasCycle(n3), Is.True);
    }

    [Test]
    public void HasCycle_SingleNode()
    {
        Assert.That(LinkedListCycle.HasCycle(new ListNode(1)), Is.False);
    }
}
