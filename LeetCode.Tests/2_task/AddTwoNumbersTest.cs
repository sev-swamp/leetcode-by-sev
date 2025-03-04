namespace LeetCode.Tests;

public class AddTwoNumbersTest
{
    [Test]
    public void AddTwoNumbers1Test()
    {
        var array1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var array2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        var result = AddTwoNumbers.AddTwoNumbers1(array1, array2);

        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void AddTwoNumbers1Test2()
    {
        var array2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        var array1 = new ListNode(9, new ListNode(9, new ListNode(9, array2)));

        var expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9,
        new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));
        var result = AddTwoNumbers.AddTwoNumbers1(array1, array2);

        Assert.That(result, Is.EqualTo(expected));
    }
}
