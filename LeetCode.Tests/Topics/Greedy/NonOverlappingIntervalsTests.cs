namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class NonOverlappingIntervalsTests
{
    [Test]
    public void EraseOverlapIntervals_BasicCase()
    {
        Assert.That(NonOverlappingIntervals.EraseOverlapIntervals([[1, 2], [2, 3], [3, 4], [1, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void EraseOverlapIntervals_NoOverlap()
    {
        Assert.That(NonOverlappingIntervals.EraseOverlapIntervals([[1, 2], [2, 3]]), Is.EqualTo(0));
    }

    [Test]
    public void EraseOverlapIntervals_AllOverlap()
    {
        Assert.That(NonOverlappingIntervals.EraseOverlapIntervals([[1, 2], [1, 2], [1, 2]]), Is.EqualTo(2));
    }
}
