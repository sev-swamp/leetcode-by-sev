namespace LeetCode.Tests;

public class ContiguousArrayTest
{
    [TestCase(new[] { 0, 1, 1, 1, 1, 1, 0, 0, 0 }, ExpectedResult = 6)]
    [TestCase(new[] { 0, 1, 0 }, ExpectedResult = 2)]
    [TestCase(new[] { 0, 1 }, ExpectedResult = 2)]
    public int FindMaxLength1Test(int[] array)
    {
        return ContiguousArray.FindMaxLength(array);
    }
}
