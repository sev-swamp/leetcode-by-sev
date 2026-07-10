namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class NetworkDelayTimeTests
{
    [Test]
    public void NetworkDelayTimeSolution_BasicCase()
    {
        Assert.That(NetworkDelayTime.NetworkDelayTimeSolution([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2), Is.EqualTo(2));
    }

    [Test]
    public void NetworkDelayTimeSolution_Unreachable()
    {
        Assert.That(NetworkDelayTime.NetworkDelayTimeSolution([[1, 2, 1]], 2, 2), Is.EqualTo(-1));
    }
}
