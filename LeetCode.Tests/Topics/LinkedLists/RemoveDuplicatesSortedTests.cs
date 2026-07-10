namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class RemoveDuplicatesSortedTests
{
    [Test]
    public void DeleteDuplicates_HasDuplicates()
    {
        var head = new ListNode(1, new ListNode(1, new ListNode(2)));
        var expected = new ListNode(1, new ListNode(2));
        Assert.That(RemoveDuplicatesSorted.DeleteDuplicates(head), Is.EqualTo(expected));
    }

    [Test]
    public void DeleteDuplicates_MultipleDuplicates()
    {
        var head = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
        var expected = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.That(RemoveDuplicatesSorted.DeleteDuplicates(head), Is.EqualTo(expected));
    }
}
