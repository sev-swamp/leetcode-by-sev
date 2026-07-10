namespace LeetCode.Tests;

[TestFixture]
[Category("TwoPointers")]
public class ThreeSumTests
{
    [Test]
    public void ThreeSumSolution_BasicCase()
    {
        var result = ThreeSum.ThreeSumSolution([-1, 0, 1, 2, -1, -4]);
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result, Has.Some.EqualTo(new List<int> { -1, -1, 2 }));
        Assert.That(result, Has.Some.EqualTo(new List<int> { -1, 0, 1 }));
    }

    [Test]
    public void ThreeSumSolution_NoResult()
    {
        Assert.That(ThreeSum.ThreeSumSolution([0, 1, 1]), Is.Empty);
    }

    [Test]
    public void ThreeSumSolution_AllZeros()
    {
        var result = ThreeSum.ThreeSumSolution([0, 0, 0]);
        Assert.That(result.Count, Is.EqualTo(1));
    }
}
