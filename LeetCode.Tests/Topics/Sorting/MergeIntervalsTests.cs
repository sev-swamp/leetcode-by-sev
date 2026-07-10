namespace LeetCode.Tests;

[TestFixture]
[Category("Sorting")]
public class MergeIntervalsTests
{
    [Test]
    public void Merge_OverlappingIntervals()
    {
        var intervals = new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };
        var expected  = new[] { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };

        Assert.That(MergeIntervals.Merge(intervals), Is.EqualTo(expected));
    }

    [Test]
    public void Merge_TouchingIntervals()
    {
        var intervals = new[] { new[] { 1, 4 }, new[] { 4, 5 } };
        var expected  = new[] { new[] { 1, 5 } };

        Assert.That(MergeIntervals.Merge(intervals), Is.EqualTo(expected));
    }

    [Test]
    public void Merge_NoOverlap()
    {
        var intervals = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } };
        var expected  = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } };

        Assert.That(MergeIntervals.Merge(intervals), Is.EqualTo(expected));
    }

    [Test]
    public void Merge_AllOverlap()
    {
        var intervals = new[] { new[] { 1, 10 }, new[] { 2, 3 }, new[] { 4, 9 } };
        var expected  = new[] { new[] { 1, 10 } };

        Assert.That(MergeIntervals.Merge(intervals), Is.EqualTo(expected));
    }
}
