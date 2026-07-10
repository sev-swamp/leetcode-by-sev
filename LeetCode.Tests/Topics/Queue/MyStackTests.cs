namespace LeetCode.Tests;

[TestFixture]
[Category("Queue")]
public class MyStackTests
{
    [Test]
    public void Stack_PushAndPop()
    {
        var stack = new MyStack();
        stack.Push(1);
        stack.Push(2);
        Assert.That(stack.Top(), Is.EqualTo(2));
        Assert.That(stack.Pop(), Is.EqualTo(2));
        Assert.That(stack.Empty(), Is.False);
    }

    [Test]
    public void Stack_EmptyAfterPops()
    {
        var stack = new MyStack();
        stack.Push(1);
        stack.Pop();
        Assert.That(stack.Empty(), Is.True);
    }
}
