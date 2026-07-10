namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class SwapNodesInPairsTests
{
    [Test]
    public void SwapPairs_EvenLength()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        var expected = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3))));
        Assert.That(SwapNodesInPairs.SwapPairs(head), Is.EqualTo(expected));
    }

    [Test]
    public void SwapPairs_OddLength()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var expected = new ListNode(2, new ListNode(1, new ListNode(3)));
        Assert.That(SwapNodesInPairs.SwapPairs(head), Is.EqualTo(expected));
    }

    [Test]
    public void SwapPairs_SingleNode()
    {
        Assert.That(SwapNodesInPairs.SwapPairs(new ListNode(1)), Is.EqualTo(new ListNode(1)));
    }

    [Test]
    public void SwapPairs_EmptyList()
    {
        Assert.That(SwapNodesInPairs.SwapPairs(null!), Is.Null);
    }
}
