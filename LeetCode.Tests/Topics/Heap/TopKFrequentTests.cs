namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class TopKFrequentTests
{
    [Test]
    public void TopKFrequentSolution_BasicCase()
    {
        var result = TopKFrequent.TopKFrequentSolution([1,1,1,2,2,3], 2);
        Assert.That(result.OrderBy(x => x).ToArray(), Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void TopKFrequentSolution_SingleElement()
    {
        Assert.That(TopKFrequent.TopKFrequentSolution([1], 1), Is.EqualTo(new[] { 1 }));
    }
}
