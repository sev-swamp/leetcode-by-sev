namespace LeetCode.Tests;

[TestFixture]
[Category("TwoPointers")]
public class IntervalListIntersectionsTests
{
    [Test]
    public void IntervalIntersection_BasicCase()
    {
        var r = IntervalListIntersections.IntervalIntersection(
            [[0, 2], [5, 10], [13, 23], [24, 25]],
            [[1, 5], [8, 12], [15, 24], [25, 26]]);
        Assert.That(r, Is.EqualTo(new[] { new[] { 1, 2 }, new[] { 5, 5 }, new[] { 8, 10 }, new[] { 15, 23 }, new[] { 24, 24 }, new[] { 25, 25 } }));
    }

    [Test]
    public void IntervalIntersection_EmptyList()
    {
        Assert.That(IntervalListIntersections.IntervalIntersection([], [[1, 2]]), Is.Empty);
    }
}
