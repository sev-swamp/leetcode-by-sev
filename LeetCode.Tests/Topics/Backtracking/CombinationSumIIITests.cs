namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class CombinationSumIIITests
{
    [Test]
    public void CombinationSum3Solution_K3N7()
    {
        var result = CombinationSumIII.CombinationSum3Solution(3, 7);
        Assert.That(result, Has.Some.EqualTo(new List<int> { 1, 2, 4 }));
    }

    [Test]
    public void CombinationSum3Solution_K3N9()
    {
        var result = CombinationSumIII.CombinationSum3Solution(3, 9);
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 1, 2, 6 }));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 1, 3, 5 }));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 2, 3, 4 }));
    }
}
