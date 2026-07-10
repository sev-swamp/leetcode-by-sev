namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class UniquePathsTests
{
    [TestCase(3, 7, ExpectedResult = 28)]
    [TestCase(3, 2, ExpectedResult = 3)]
    [TestCase(1, 1, ExpectedResult = 1)]
    public int UniquePathsSolution(int m, int n) =>
        UniquePaths.UniquePathsSolution(m, n);
}
