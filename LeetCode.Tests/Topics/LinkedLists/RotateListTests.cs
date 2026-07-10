namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class RotateListTests
{
    [Test]
    public void RotateRight_BasicCase()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(2, new ListNode(3)))));
        Assert.That(RotateList.RotateRight(head, 2), Is.EqualTo(expected));
    }

    [Test]
    public void RotateRight_K0()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.That(RotateList.RotateRight(head, 0), Is.EqualTo(head));
    }
}
