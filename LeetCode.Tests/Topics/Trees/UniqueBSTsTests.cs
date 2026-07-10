namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class UniqueBSTsTests
{
    [TestCase(3, ExpectedResult = 5)]
    [TestCase(1, ExpectedResult = 1)]
    [TestCase(4, ExpectedResult = 14)]
    public int NumTrees(int n) => UniqueBSTs.NumTrees(n);
}
