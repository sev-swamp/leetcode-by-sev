namespace LeetCode.Tests;

[TestFixture]
[Category("HashMaps")]
public class WordPatternTests
{
    [TestCase("abba", "dog cat cat dog",  ExpectedResult = true)]
    [TestCase("abba", "dog cat cat fish", ExpectedResult = false)]
    [TestCase("aaaa", "dog cat cat dog",  ExpectedResult = false)]
    [TestCase("abba", "dog dog dog dog",  ExpectedResult = false)]
    public bool WordPatternSolution(string pattern, string s) =>
        WordPattern.WordPatternSolution(pattern, s);
}
