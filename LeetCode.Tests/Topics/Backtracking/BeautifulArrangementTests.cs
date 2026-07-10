namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class BeautifulArrangementTests
{
    [TestCase(1, ExpectedResult = 1)]
    [TestCase(2, ExpectedResult = 2)]
    [TestCase(3, ExpectedResult = 3)]
    public int CountArrangement(int n) =>
        BeautifulArrangement.CountArrangement(n);
}
