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


    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, ExpectedResult = new[] { 4, 3, 2, 7, 8, 1 })]
    [TestCase(new[] { 1, 1, 2 }, ExpectedResult = new[] { 1, 2 })]
    [TestCase(new[] { 1 }, ExpectedResult = new int[] { 1 })]
    public int[] RemoveDuplicatesTest(int[] array)
    {
        return FindDuplicate.RemoveDuplicates(array);
    }


    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, ExpectedResult = false)]
    [TestCase(new[] { 1, 1, 2 }, ExpectedResult = true)]
    [TestCase(new[] { 1 }, ExpectedResult = true)]
    public bool IsUpperArrayTest(int[] array)
    {
        return FindDuplicate.IsUpperArray(array);
    }
}