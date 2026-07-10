namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class RegularExpressionMatchingTests
{
    [TestCase("aa", "a", ExpectedResult = false)]
    [TestCase("aa", "a*", ExpectedResult = true)]
    [TestCase("ab", ".*", ExpectedResult = true)]
    [TestCase("aab", "c*a*b", ExpectedResult = true)]
    public bool IsMatch(string s, string p) =>
        RegularExpressionMatching.IsMatch(s, p);
}
