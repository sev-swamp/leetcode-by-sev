namespace LeetCode.Tests;

[TestFixture]
[Category("Other")]
public class StringToIntegerTests
{
    [TestCase("42", ExpectedResult = 42)]
    [TestCase("   -42", ExpectedResult = -42)]
    [TestCase("4193 with words", ExpectedResult = 4193)]
    [TestCase("words and 987", ExpectedResult = 0)]
    [TestCase("-91283472332", ExpectedResult = -2147483648)]
    public int MyAtoi(string s) => StringToInteger.MyAtoi(s);
}
