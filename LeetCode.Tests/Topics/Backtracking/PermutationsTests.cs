namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class PermutationsTests
{
    [Test]
    public void Permute_ThreeElements()
    {
        var result = Permutations.Permute([1, 2, 3]);
        Assert.That(result.Count, Is.EqualTo(6));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 1, 2, 3 }));
        Assert.That(result, Has.Some.EqualTo(new List<int> { 3, 2, 1 }));
    }

    [Test]
    public void Permute_SingleElement()
    {
        var result = Permutations.Permute([0]);
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result[0], Is.EqualTo(new List<int> { 0 }));
    }
}
