namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class PalindromePartitioningTests
{
    [Test]
    public void PartitionSolution_BasicCase()
    {
        var r = PalindromePartitioning.PartitionSolution("aab");
        Assert.That(r.Count, Is.EqualTo(2));
        Assert.That(r, Has.Some.EqualTo(new List<string> { "a", "a", "b" }));
        Assert.That(r, Has.Some.EqualTo(new List<string> { "aa", "b" }));
    }

    [Test]
    public void PartitionSolution_SingleChar()
    {
        Assert.That(PalindromePartitioning.PartitionSolution("a").Count, Is.EqualTo(1));
    }
}
