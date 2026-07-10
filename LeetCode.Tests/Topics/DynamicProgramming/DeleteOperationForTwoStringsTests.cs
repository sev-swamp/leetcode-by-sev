namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class DeleteOperationForTwoStringsTests
{
    [TestCase("sea", "eat", ExpectedResult = 2)]
    [TestCase("leetcode", "etco", ExpectedResult = 4)]
    public int MinDistance2(string word1, string word2) =>
        DeleteOperationForTwoStrings.MinDistance2(word1, word2);
}
