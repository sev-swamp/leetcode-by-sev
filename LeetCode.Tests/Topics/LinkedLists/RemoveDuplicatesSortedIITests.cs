namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class RemoveDuplicatesSortedIITests
{
    [Test]
    public void DeleteDuplicatesII_RemovesAllDuplicates()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))));
        var expected = new ListNode(1, new ListNode(2, new ListNode(5)));
        Assert.That(RemoveDuplicatesSortedII.DeleteDuplicatesII(head), Is.EqualTo(expected));
    }

    [Test]
    public void DeleteDuplicatesII_AllDuplicates()
    {
        var head = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3)))));
        var expected = new ListNode(2, new ListNode(3));
        Assert.That(RemoveDuplicatesSortedII.DeleteDuplicatesII(head), Is.EqualTo(expected));
    }
}
