namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class RemoveAdjacentDuplicatesIITests
{
    [TestCase("abcd",                     2, ExpectedResult = "abcd")]
    [TestCase("deeedbbcccbdaa",           3, ExpectedResult = "aa")]
    [TestCase("pbbcggttciiippooaais",     2, ExpectedResult = "ps")]
    public string RemoveDuplicates(string s, int k) =>
        RemoveAdjacentDuplicatesII.RemoveDuplicates(s, k);
}
