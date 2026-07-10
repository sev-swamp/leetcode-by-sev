namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class NthDigitTests
{
    [TestCase(3,  ExpectedResult = 3)]
    [TestCase(11, ExpectedResult = 0)]
    [TestCase(12, ExpectedResult = 1)]
    public int FindNthDigit(int n) =>
        NthDigit.FindNthDigit(n);
}
