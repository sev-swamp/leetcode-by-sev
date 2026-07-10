namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class PartitionLabelsTests
{
    [Test]
    public void PartitionLabelsSolution_BasicCase()
    {
        Assert.That(PartitionLabels.PartitionLabelsSolution("ababcbacadefegdehijhklij"), Is.EqualTo(new List<int> { 9, 7, 8 }));
    }

    [Test]
    public void PartitionLabelsSolution_SingleChar()
    {
        Assert.That(PartitionLabels.PartitionLabelsSolution("a"), Is.EqualTo(new List<int> { 1 }));
    }
}
