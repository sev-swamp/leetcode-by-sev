namespace LeetCode.Tests;

public class MoveZeroeTest
{
    [TestCase(new[] { 0, 1, 0, 3, 12 }, ExpectedResult = new[] { 1, 3, 12, 0, 0 })]
    [TestCase(new[] { 0 }, ExpectedResult = new[] { 0 })]
    [TestCase(new[] { 1, 0, 1 }, ExpectedResult = new[] { 1, 1, 0 })]

    public int[] MoveZeroesTest(int[] array)
    {
        MoveZeroe.MoveZeroes(array);
        return array;
    }


}
