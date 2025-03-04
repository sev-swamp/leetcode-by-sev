namespace LeetCode.Tests;

public class PivotIndexTest
{
    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, ExpectedResult = 3)]
    [TestCase(new[] { 1, 2, 3 }, ExpectedResult = -1)]
    [TestCase(new[] { 2, 1, -1 }, ExpectedResult = 0)]

    public int PivotsIndexTest(int[] array)
    {
        return PivotIndex.PivotsIndex(array);
    }
}
