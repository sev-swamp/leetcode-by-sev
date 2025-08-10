namespace LeetCode.Tests;

public class LargeNumberTest
{
    [SetUp]
    public void Setup() { }

    [TestCase(new[] { 10, 2 }, ExpectedResult = "210")]
    [TestCase(new[] { 3, 30, 34, 5, 9 }, ExpectedResult = "9534330")]
    public string LongestMountainTest(int[] array)
    {
        return LargeNumber.LargestNumber2Task(array);
    }
}