namespace LeetCode.Tests;

[TestFixture]
[Category("BinarySearch")]
public class FirstBadVersionTests
{
    [Test]
    public void FirstBadVersion_MiddleOfRange()
    {
        Assert.That(FirstBadVersion.FirstBadVersionSolution(5, v => v >= 4), Is.EqualTo(4));
    }

    [Test]
    public void FirstBadVersion_FirstVersion()
    {
        Assert.That(FirstBadVersion.FirstBadVersionSolution(1, v => v >= 1), Is.EqualTo(1));
    }

    [Test]
    public void FirstBadVersion_LastVersion()
    {
        Assert.That(FirstBadVersion.FirstBadVersionSolution(10, v => v >= 10), Is.EqualTo(10));
    }

    [Test]
    public void FirstBadVersion_LargeN()
    {
        Assert.That(FirstBadVersion.FirstBadVersionSolution(2147483647, v => v >= 1702766719), Is.EqualTo(1702766719));
    }
}
