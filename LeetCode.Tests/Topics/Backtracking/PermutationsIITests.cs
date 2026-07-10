namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class PermutationsIITests
{
    [Test]
    public void PermuteUnique_WithDuplicates()
    {
        var r = PermutationsII.PermuteUnique([1, 1, 2]);
        Assert.That(r.Count, Is.EqualTo(3));
        Assert.That(r, Has.Some.EqualTo(new List<int> { 1, 1, 2 }));
        Assert.That(r, Has.Some.EqualTo(new List<int> { 1, 2, 1 }));
        Assert.That(r, Has.Some.EqualTo(new List<int> { 2, 1, 1 }));
    }

    [Test]
    public void PermuteUnique_AllSame()
    {
        Assert.That(PermutationsII.PermuteUnique([1, 1, 1]).Count, Is.EqualTo(1));
    }
}
