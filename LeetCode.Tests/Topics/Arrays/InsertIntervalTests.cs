namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class InsertIntervalTests
{
    [Test]
    public void Insert_MergesOverlapping()
    {
        Assert.That(InsertInterval.Insert([[1, 3], [6, 9]], [2, 5]), Is.EqualTo(new[] { new[] { 1, 5 }, new[] { 6, 9 } }));
    }

    [Test]
    public void Insert_InMiddle()
    {
        Assert.That(InsertInterval.Insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]), Is.EqualTo(new[] { new[] { 1, 2 }, new[] { 3, 10 }, new[] { 12, 16 } }));
    }

    [Test]
    public void Insert_EmptyList()
    {
        Assert.That(InsertInterval.Insert([], [5, 7]), Is.EqualTo(new[] { new[] { 5, 7 } }));
    }
}
