namespace LeetCode.Tests;

[TestFixture]
[Category("TwoPointers")]
public class ValidPalindromeTests
{
    [TestCase("A man, a plan, a canal: Panama", ExpectedResult = true)]
    [TestCase("race a car",                     ExpectedResult = false)]
    [TestCase(" ",                              ExpectedResult = true)]
    public bool IsPalindrome(string s) =>
        ValidPalindrome.IsPalindrome(s);
}
