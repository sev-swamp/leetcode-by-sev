namespace LeetCode.Tests;

[TestFixture]
[Category("Other")]
public class ZigzagConversionTests
{
    [TestCase("PAYPALISHIRING", 3, ExpectedResult = "PAHNAPLSIIGYIR")]
    [TestCase("PAYPALISHIRING", 4, ExpectedResult = "PINALSIGYAHRPI")]
    [TestCase("A",              1, ExpectedResult = "A")]
    [TestCase("AB",             1, ExpectedResult = "AB")]
    public string Convert(string s, int numRows) =>
        ZigzagConversion.Convert(s, numRows);
}
