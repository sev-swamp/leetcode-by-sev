namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class KokoEatingBananasTests
{
    [TestCase(new[] { 3, 6, 7, 11 },      8, ExpectedResult = 4)]
    [TestCase(new[] { 30, 11, 23, 4, 20 }, 5, ExpectedResult = 30)]
    [TestCase(new[] { 30, 11, 23, 4, 20 }, 6, ExpectedResult = 23)]
    [TestCase(new[] { 312884470 },         312884469, ExpectedResult = 2)]
    public int MinEatingSpeed(int[] piles, int h) =>
        KokoEatingBananas.MinEatingSpeed(piles, h);
}
