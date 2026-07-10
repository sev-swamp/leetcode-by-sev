namespace LeetCode.Tests;

[TestFixture]
[Category("LinkedLists")]
public class FlattenMultilevelDLLTests
{
    [Test]
    public void Flatten_NullInput()
    {
        Assert.That(FlattenMultilevelDLL.Flatten(null!), Is.Null);
    }

    [Test]
    public void Flatten_NoChildren()
    {
        var n = new MultilevelNode(1); n.next = new MultilevelNode(2);
        var result = FlattenMultilevelDLL.Flatten(n);
        Assert.That(result.val, Is.EqualTo(1));
        Assert.That(result.next!.val, Is.EqualTo(2));
    }
}
