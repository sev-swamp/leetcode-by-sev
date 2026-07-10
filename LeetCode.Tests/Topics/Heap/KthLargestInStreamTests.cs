namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class KthLargestInStreamTests
{
    [Test]
    public void KthLargest_StreamUpdates()
    {
        var stream = new KthLargest(3, [4, 5, 8, 2]);
        Assert.That(stream.Add(3), Is.EqualTo(4));
        Assert.That(stream.Add(5), Is.EqualTo(5));
        Assert.That(stream.Add(10), Is.EqualTo(5));
        Assert.That(stream.Add(9), Is.EqualTo(8));
        Assert.That(stream.Add(4), Is.EqualTo(8));
    }
}
