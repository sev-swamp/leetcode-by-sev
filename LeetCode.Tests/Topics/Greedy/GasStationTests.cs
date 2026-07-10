namespace LeetCode.Tests;

[TestFixture]
[Category("Greedy")]
public class GasStationTests
{
    [Test]
    public void CanCompleteCircuit_BasicCase()
    {
        Assert.That(GasStation.CanCompleteCircuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]), Is.EqualTo(3));
    }

    [Test]
    public void CanCompleteCircuit_Impossible()
    {
        Assert.That(GasStation.CanCompleteCircuit([2, 3, 4], [3, 4, 3]), Is.EqualTo(-1));
    }
}
