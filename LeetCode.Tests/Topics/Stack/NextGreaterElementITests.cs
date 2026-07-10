namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class NextGreaterElementITests
{
    [Test]
    public void NextGreaterElement_BasicCase()
    {
        Assert.That(NextGreaterElementI.NextGreaterElement([4, 1, 2], [1, 3, 4, 2]), Is.EqualTo(new[] { -1, 3, -1 }));
    }

    [Test]
    public void NextGreaterElement_AllHaveNext()
    {
        Assert.That(NextGreaterElementI.NextGreaterElement([2, 4], [1, 2, 3, 4]), Is.EqualTo(new[] { 3, -1 }));
    }
}
