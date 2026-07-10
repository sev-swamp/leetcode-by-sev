namespace LeetCode.Tests;

[TestFixture]
[Category("HashMaps")]
public class TwoSumTests
{
    [Test]
    public void TwoSumSolution_BasicCase()
    {
        Assert.That(TwoSum.TwoSumSolution([2, 7, 11, 15], 9), Is.EqualTo(new[] { 0, 1 }));
    }

    [Test]
    public void TwoSumSolution_NotFirst()
    {
        Assert.That(TwoSum.TwoSumSolution([3, 2, 4], 6), Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void TwoSumSolution_SameElement()
    {
        Assert.That(TwoSum.TwoSumSolution([3, 3], 6), Is.EqualTo(new[] { 0, 1 }));
    }
}
