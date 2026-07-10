namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class MinimumWindowSubstringTests
{
    [TestCase("ADOBECODEBANC", "ABC", ExpectedResult = "BANC")]
    [TestCase("a",             "a",   ExpectedResult = "a")]
    [TestCase("a",             "aa",  ExpectedResult = "")]
    public string MinWindow(string s, string t) =>
        MinimumWindowSubstring.MinWindow(s, t);
}
