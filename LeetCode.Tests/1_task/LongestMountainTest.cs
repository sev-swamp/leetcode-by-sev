namespace LeetCode.Tests;

public class LongestMountainTestArray
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 2, 3, 3, 2, 0, 2 }, ExpectedResult = 0)]
    [TestCase(new[] { 0, 2, 0, 2, 1, 2, 3, 4, 4, 1 }, ExpectedResult = 3)]
    [TestCase(new[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 }, ExpectedResult = 11)]
    [TestCase(new[] { 2, 1, 4, 7, 3, 2, 5 }, ExpectedResult = 5)]
    [TestCase(new[] { 2, 2, 2 }, ExpectedResult = 0)]
    [TestCase(new[] { 1, 1, 0, 0, 1, 0 }, ExpectedResult = 3)]
    public int LongestMountainTest(int[] array)
    {
        return LongestMountain.LongestMountains(array);
    }
}