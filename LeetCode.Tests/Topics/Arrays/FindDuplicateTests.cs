namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class FindDuplicateTests
{
    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, ExpectedResult = new[] { 2, 3 })]
    [TestCase(new[] { 1, 1, 2 },                 ExpectedResult = new[] { 1 })]
    [TestCase(new[] { 1 },                        ExpectedResult = new int[] { })]
    public int[] FindDuplicates(int[] nums) =>
        FindDuplicate.FindDuplicates(nums).ToArray();

    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, ExpectedResult = new[] { 4, 3, 2, 7, 8, 1 })]
    [TestCase(new[] { 1, 1, 2 },                 ExpectedResult = new[] { 1, 2 })]
    [TestCase(new[] { 1 },                        ExpectedResult = new[] { 1 })]
    public int[] RemoveDuplicates(int[] nums) =>
        FindDuplicate.RemoveDuplicates(nums);

    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, ExpectedResult = false)]
    [TestCase(new[] { 1, 1, 2 },                 ExpectedResult = true)]
    [TestCase(new[] { 1 },                        ExpectedResult = true)]
    public bool IsUpperArray(int[] nums) =>
        FindDuplicate.IsUpperArray(nums);
}
