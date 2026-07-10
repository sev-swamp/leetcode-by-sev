namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class SubsetsTests
{
    [Test]
    public void SubsetsSolution_ThreeElements()
    {
        var r = Subsets.SubsetsSolution([1, 2, 3]);
        Assert.That(r.Count, Is.EqualTo(8));
        Assert.That(r, Has.Some.EqualTo(new List<int>()));
        Assert.That(r, Has.Some.EqualTo(new List<int> { 1, 2, 3 }));
    }

    [Test]
    public void SubsetsSolution_SingleElement()
    {
        Assert.That(Subsets.SubsetsSolution([0]).Count, Is.EqualTo(2));
    }
}
