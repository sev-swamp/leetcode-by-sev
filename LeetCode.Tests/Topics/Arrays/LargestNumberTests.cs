namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class LargestNumberTests
{
    [TestCase(new[] { 10, 2 },          ExpectedResult = "210")]
    [TestCase(new[] { 3, 30, 34, 5, 9 }, ExpectedResult = "9534330")]
    [TestCase(new[] { 0, 0 },           ExpectedResult = "0")]
    public string LargestNumberTask(int[] nums) =>
        LargestNumber.LargestNumberTask(nums);

    [TestCase(new[] { 10, 2 },          ExpectedResult = "210")]
    [TestCase(new[] { 3, 30, 34, 5, 9 }, ExpectedResult = "9534330")]
    public string LargestNumber2Task(int[] nums) =>
        LargestNumber.LargestNumber2Task(nums);
}
