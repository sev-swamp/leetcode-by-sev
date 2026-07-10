namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class LongestPalindromicSubstringTests
{
    [Test]
    public void LongestPalindrome_Babad()
    {
        var r = LongestPalindromicSubstring.LongestPalindrome("babad");
        Assert.That(r, Is.EqualTo("bab").Or.EqualTo("aba"));
    }

    [Test]
    public void LongestPalindrome_Cbbd()
    {
        Assert.That(LongestPalindromicSubstring.LongestPalindrome("cbbd"), Is.EqualTo("bb"));
    }

    [Test]
    public void LongestPalindrome_SingleChar()
    {
        Assert.That(LongestPalindromicSubstring.LongestPalindrome("a"), Is.EqualTo("a"));
    }
}
