namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class DailyTemperaturesTests
{
    [Test]
    public void DailyTemperaturesSolution_BasicCase()
    {
        Assert.That(DailyTemperatures.DailyTemperaturesSolution([73, 74, 75, 71, 69, 72, 76, 73]), Is.EqualTo(new[] { 1, 1, 4, 2, 1, 1, 0, 0 }));
    }

    [Test]
    public void DailyTemperaturesSolution_Decreasing()
    {
        Assert.That(DailyTemperatures.DailyTemperaturesSolution([30, 20, 10]), Is.EqualTo(new[] { 0, 0, 0 }));
    }
}
