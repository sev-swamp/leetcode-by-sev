namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class SlidingWindowMaximumTests
{
    [Test]
    public void MaxSlidingWindow_BasicCase()
    {
        Assert.That(SlidingWindowMaximum.MaxSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3), Is.EqualTo(new[] { 3, 3, 5, 5, 6, 7 }));
    }

    [Test]
    public void MaxSlidingWindow_K1()
    {
        Assert.That(SlidingWindowMaximum.MaxSlidingWindow([1, 3, 1], 1), Is.EqualTo(new[] { 1, 3, 1 }));
    }
}
