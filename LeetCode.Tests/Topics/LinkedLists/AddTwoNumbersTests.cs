namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class AddTwoNumbersTests
{
    [Test]
    public void AddTwoNumbers1_BasicCase()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));

        Assert.That(AddTwoNumbers.AddTwoNumbers1(l1, l2), Is.EqualTo(expected));
    }

    [Test]
    public void AddTwoNumbers1_LargeNumbers()
    {
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, l2)));
        var expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9,
            new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));

        Assert.That(AddTwoNumbers.AddTwoNumbers1(l1, l2), Is.EqualTo(expected));
    }
}
