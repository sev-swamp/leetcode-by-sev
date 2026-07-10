namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class RemoveKDigitsTests
{
    [TestCase("1432219", 3, ExpectedResult = "1219")]
    [TestCase("10200",   1, ExpectedResult = "200")]
    [TestCase("10",      2, ExpectedResult = "0")]
    public string RemoveKdigits(string num, int k) =>
        RemoveKDigits.RemoveKdigits(num, k);
}
