namespace LeetCode.Tests;

[TestFixture]
[Category("DynamicProgramming")]
public class PartitionEqualSubsetSumTests
{
    [TestCase(new[] { 1, 5, 11, 5 }, ExpectedResult = true)]
    [TestCase(new[] { 1, 2, 3, 5 }, ExpectedResult = false)]
    [TestCase(new[] { 1, 1 }, ExpectedResult = true)]
    public bool CanPartition(int[] nums) =>
        PartitionEqualSubsetSum.CanPartition(nums);
}
