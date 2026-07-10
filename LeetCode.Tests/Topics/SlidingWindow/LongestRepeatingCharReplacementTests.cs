namespace LeetCode.Tests;

[TestFixture]
[Category("SlidingWindow")]
public class LongestRepeatingCharReplacementTests
{
    [TestCase("ABAB",    2, ExpectedResult = 4)]
    [TestCase("AABABBA", 1, ExpectedResult = 4)]
    [TestCase("AAAA",    0, ExpectedResult = 4)]
    [TestCase("ABCD",    1, ExpectedResult = 2)]
    public int CharacterReplacement(string s, int k) =>
        LongestRepeatingCharReplacement.CharacterReplacement(s, k);
}
