namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class SortedArrayToBSTTests
{
    [Test]
    public void SortedArrayToBSTSolution_OddLength()
    {
        var result = SortedArrayToBST.SortedArrayToBSTSolution([-10, -3, 0, 5, 9]);
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(0)); // middle element as root
    }

    [Test]
    public void SortedArrayToBSTSolution_EvenLength()
    {
        var result = SortedArrayToBST.SortedArrayToBSTSolution([1, 3]);
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(1).Or.EqualTo(3));
    }
}
