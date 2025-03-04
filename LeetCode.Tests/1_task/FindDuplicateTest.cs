namespace LeetCode.Tests;

public class FindDuplicateTestArray
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, ExpectedResult = new[] { 2, 3 })]
    [TestCase(new[] { 1, 1, 2 }, ExpectedResult = new[] { 1 })]
    [TestCase(new[] { 1 }, ExpectedResult = new int[] { })]
    public int[] FindDuplicateTest(int[] array)
    {
        return FindDuplicate.FindDuplicates(array).ToArray();
    }
}