namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class LongestPalindromicSubsequenceTests
{
    [TestCase("bbbab", ExpectedResult = 4)]
    [TestCase("cbbd", ExpectedResult = 2)]
    [TestCase("a", ExpectedResult = 1)]
    public int LongestPalindromeSubseq(string s) =>
        LongestPalindromicSubsequence.LongestPalindromeSubseq(s);
}
