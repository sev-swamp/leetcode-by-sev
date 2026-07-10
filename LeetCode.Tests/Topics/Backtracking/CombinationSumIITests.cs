namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class CombinationSumIITests
{
    [Test]
    public void CombinationSum2Solution_BasicCase()
    {
        var r = CombinationSumII.CombinationSum2Solution([10, 1, 2, 7, 6, 1, 5], 8);
        Assert.That(r.Count, Is.EqualTo(4));
        Assert.That(r, Has.Some.EqualTo(new List<int> { 1, 1, 6 }));
        Assert.That(r, Has.Some.EqualTo(new List<int> { 1, 2, 5 }));
    }

    [Test]
    public void CombinationSum2Solution_NoDuplicates()
    {
        var r = CombinationSumII.CombinationSum2Solution([2, 5, 2, 1, 2], 5);
        Assert.That(r.Count, Is.EqualTo(2));
    }
}
