namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class FindAllAnagramsTests
{
    [Test]
    public void FindAnagrams_BasicCase()
    {
        Assert.That(FindAllAnagrams.FindAnagrams("cbaebabacd", "abc"), Is.EqualTo(new List<int> { 0, 6 }));
    }

    [Test]
    public void FindAnagrams_ConsecutiveAnagrams()
    {
        Assert.That(FindAllAnagrams.FindAnagrams("abab", "ab"), Is.EqualTo(new List<int> { 0, 1, 2 }));
    }
}
