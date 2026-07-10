namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class CloneGraphTests
{
    [Test]
    public void CloneGraphSolution_NullInput()
    {
        Assert.That(CloneGraph.CloneGraphSolution(null!), Is.Null);
    }

    [Test]
    public void CloneGraphSolution_SingleNode()
    {
        var node = new GraphNode(1);
        var clone = CloneGraph.CloneGraphSolution(node);
        Assert.That(clone, Is.Not.SameAs(node));
        Assert.That(clone.val, Is.EqualTo(1));
    }
}
