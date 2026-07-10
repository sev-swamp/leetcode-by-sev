namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class LetterCombinationsTests
{
    [Test]
    public void LetterCombinations_TwoDigits()
    {
        var result = LetterCombinations.LetterCombinationsSolution("23");
        Assert.That(result.Count, Is.EqualTo(9));
        Assert.That(result, Has.Member("ad"));
        Assert.That(result, Has.Member("cf"));
    }

    [Test]
    public void LetterCombinations_EmptyString()
    {
        Assert.That(LetterCombinations.LetterCombinationsSolution(""), Is.Empty);
    }
}
