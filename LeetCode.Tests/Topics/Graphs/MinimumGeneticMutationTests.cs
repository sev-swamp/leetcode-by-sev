namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class MinimumGeneticMutationTests
{
    [Test]
    public void MinMutation_OneMutation()
    {
        Assert.That(MinimumGeneticMutation.MinMutation("AACCGGTT", "AACCGGTA", ["AACCGGTA"]), Is.EqualTo(1));
    }

    [Test]
    public void MinMutation_TwoMutations()
    {
        Assert.That(MinimumGeneticMutation.MinMutation("AACCGGTT", "AAACGGTA", ["AACCGGTA","AACCGCTA","AAACGGTA"]), Is.EqualTo(2));
    }

    [Test]
    public void MinMutation_Impossible()
    {
        Assert.That(MinimumGeneticMutation.MinMutation("AAAAACCC", "AACCCCCC", ["AAAACCCC","AAACCCCC","AACCCCCC"]), Is.EqualTo(3));
    }
}
