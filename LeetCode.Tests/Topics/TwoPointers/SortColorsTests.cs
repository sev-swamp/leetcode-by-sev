namespace LeetCode.Tests;

[TestFixture]
[Category("TwoPointers")]
public class SortColorsTests
{
    [Test]
    public void SortColorsSolution_BasicCase()
    {
        int[] n = [2, 0, 2, 1, 1, 0];
        SortColors.SortColorsSolution(n);
        Assert.That(n, Is.EqualTo(new[] { 0, 0, 1, 1, 2, 2 }));
    }
    [Test]
    public void SortColorsSolution_BasicCase2()
    {
        int[] n = [2, 0, 1];
        SortColors.SortColorsSolution(n);
        Assert.That(n, Is.EqualTo(new[] { 0, 1, 2 }));
    }

    [Test]
    public void SortColorsSolution_AlreadySorted()
    {
        int[] n = [0, 1, 2];
        SortColors.SortColorsSolution(n);
        Assert.That(n, Is.EqualTo(new[] { 0, 1, 2 }));
    }
}
