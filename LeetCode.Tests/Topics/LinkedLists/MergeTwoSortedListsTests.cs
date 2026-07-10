namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class MergeTwoSortedListsTests
{
    [Test]
    public void MergeTwoListsSolution_BasicCase()
    {
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
        Assert.That(MergeTwoSortedLists.MergeTwoListsSolution(l1, l2), Is.EqualTo(expected));
    }

    [Test]
    public void MergeTwoListsSolution_EmptyLists()
    {
        Assert.That(MergeTwoSortedLists.MergeTwoListsSolution(null!, null!), Is.Null);
    }

    [Test]
    public void MergeTwoListsSolution_OneEmpty()
    {
        var l = new ListNode(0);
        Assert.That(MergeTwoSortedLists.MergeTwoListsSolution(null!, l), Is.EqualTo(l));
    }
}
