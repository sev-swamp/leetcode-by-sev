namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class ReorganizeStringTests
{
    [Test]
    public void ReorganizeStringSolution_ValidResult()
    {
        var result = ReorganizeString.ReorganizeStringSolution("aab");
        Assert.That(result, Is.Not.Empty);
        for (int i = 1; i < result.Length; i++)
            Assert.That(result[i], Is.Not.EqualTo(result[i-1]));
    }

    [Test]
    public void ReorganizeStringSolution_Impossible()
    {
        Assert.That(ReorganizeString.ReorganizeStringSolution("aaab"), Is.EqualTo(""));
    }
}
