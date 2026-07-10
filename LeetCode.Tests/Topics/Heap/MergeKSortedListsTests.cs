namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class MergeKSortedListsTests
{
    [Test]
    public void MergeKLists_BasicCase()
    {
        var lists = new ListNode[]
        {
            new ListNode(1, new ListNode(4, new ListNode(5))),
            new ListNode(1, new ListNode(3, new ListNode(4))),
            new ListNode(2, new ListNode(6))
        };
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, new ListNode(6))))))));
        Assert.That(MergeKSortedLists.MergeKLists(lists), Is.EqualTo(expected));
    }

    [Test]
    public void MergeKLists_EmptyArray()
    {
        Assert.That(MergeKSortedLists.MergeKLists([]), Is.Null);
    }
}
