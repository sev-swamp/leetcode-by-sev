namespace LeetCode.Tests;

[TestFixture]
[Category("HashMaps")]
public class BullsAndCowsTests
{
    [TestCase("1807", "7810", ExpectedResult = "1A3B")]
    [TestCase("1123", "0111", ExpectedResult = "1A1B")]
    public string GetHint(string secret, string guess) =>
        BullsAndCows.GetHint(secret, guess);
}
