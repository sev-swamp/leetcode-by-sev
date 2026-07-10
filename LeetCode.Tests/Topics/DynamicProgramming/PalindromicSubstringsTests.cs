namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class PalindromicSubstringsTests
{
    [TestCase("abc", ExpectedResult = 3)]
    [TestCase("aaa", ExpectedResult = 6)]
    public int CountSubstrings(string s) =>
        PalindromicSubstrings.CountSubstrings(s);
}
