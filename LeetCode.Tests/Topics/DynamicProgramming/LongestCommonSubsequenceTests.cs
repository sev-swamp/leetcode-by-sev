namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class LongestCommonSubsequenceTests
{
    [TestCase("abcde", "ace", ExpectedResult = 3)]
    [TestCase("abc", "abc", ExpectedResult = 3)]
    [TestCase("abc", "def", ExpectedResult = 0)]
    public int LongestCommonSubsequenceSolution(string text1, string text2) =>
        LongestCommonSubsequence.LongestCommonSubsequenceSolution(text1, text2);
}
