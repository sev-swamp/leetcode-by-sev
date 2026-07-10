namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class CombinationSumTests
{
    [Test]
    public void CombinationSumSolution_BasicCase()
    {
        var result = CombinationSum.CombinationSumSolution([2, 3, 6, 7], 7);
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 2, 2, 3 }));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 7 }));
    }

    [Test]
    public void CombinationSumSolution_NoPossible()
    {
        Assert.That(CombinationSum.CombinationSumSolution([2], 1), Is.Empty);
    }
}
