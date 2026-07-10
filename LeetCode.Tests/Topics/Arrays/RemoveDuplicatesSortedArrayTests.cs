namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class RemoveDuplicatesSortedArrayTests
{
    [Test]
    public void RemoveDuplicates_BasicCase()
    {
        int[] n = [1, 1, 2];
        Assert.That(RemoveDuplicatesSortedArray.RemoveDuplicates(n), Is.EqualTo(2));
        Assert.That(n[..2], Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void RemoveDuplicates_NoDuplicates()
    {
        int[] n = [1, 2, 3];
        Assert.That(RemoveDuplicatesSortedArray.RemoveDuplicates(n), Is.EqualTo(3));
    }
}
