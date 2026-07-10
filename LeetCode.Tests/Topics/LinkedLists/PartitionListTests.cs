namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class PartitionListTests
{
    [Test]
    public void Partition_BasicCase()
    {
        var head = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(2))))));
        var expected = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(5))))));
        Assert.That(PartitionList.Partition(head, 3), Is.EqualTo(expected));
    }

    [Test]
    public void Partition_AllLess()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var expected = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.That(PartitionList.Partition(head, 5), Is.EqualTo(expected));
    }
}
