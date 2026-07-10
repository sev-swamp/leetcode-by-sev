namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class SlidingWindowMedianTests
{
    [Test]
    public void MedianSlidingWindow_OddK()
    {
        Assert.That(SlidingWindowMedian.MedianSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3), Is.EqualTo(new double[] { 1.0, -1.0, -1.0, 3.0, 5.0, 6.0 }));
    }

    [Test]
    public void MedianSlidingWindow_K1()
    {
        Assert.That(SlidingWindowMedian.MedianSlidingWindow([1, 2, 3, 4, 2, 3, 1, 4, 2], 1), Is.EqualTo(new double[] { 1.0, 2.0, 3.0, 4.0, 2.0, 3.0, 1.0, 4.0, 2.0 }));
    }
}
