namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class MyQueueTests
{
    [Test]
    public void MyQueue_FIFOOrder()
    {
        var q = new MyQueue();
        q.Push(1);
        q.Push(2);
        Assert.That(q.Peek(), Is.EqualTo(1));
        Assert.That(q.Pop(), Is.EqualTo(1));
        Assert.That(q.Empty(), Is.False);
    }

    [Test]
    public void MyQueue_EmptyAfterPops()
    {
        var q = new MyQueue();
        q.Push(1);
        q.Pop();
        Assert.That(q.Empty(), Is.True);
    }
}
