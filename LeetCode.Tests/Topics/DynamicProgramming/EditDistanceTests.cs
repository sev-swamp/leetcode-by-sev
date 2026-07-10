namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class EditDistanceTests
{
    [TestCase("horse", "ros", ExpectedResult = 3)]
    [TestCase("intention", "execution", ExpectedResult = 5)]
    [TestCase("", "a", ExpectedResult = 1)]
    public int MinDistance(string word1, string word2) =>
        EditDistance.MinDistance(word1, word2);
}
