namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class MinStackTests
{
    [Test]
    public void MinStack_BasicOperations()
    {
        var stack = new MinStack();
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        Assert.That(stack.GetMin(), Is.EqualTo(-3));
        stack.Pop();
        Assert.That(stack.Top(), Is.EqualTo(0));
        Assert.That(stack.GetMin(), Is.EqualTo(-2));
    }
}
