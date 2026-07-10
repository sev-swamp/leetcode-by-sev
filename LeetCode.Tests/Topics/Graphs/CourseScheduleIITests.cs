namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class CourseScheduleIITests
{
    [Test]
    public void FindOrder_BasicCase()
    {
        Assert.That(CourseScheduleII.FindOrder(2, [[1, 0]]), Is.EqualTo(new[] { 0, 1 }));
    }

    [Test]
    public void FindOrder_HasCycle()
    {
        Assert.That(CourseScheduleII.FindOrder(2, [[1, 0], [0, 1]]), Is.Empty);
    }

    [Test]
    public void FindOrder_NoPrereqs()
    {
        Assert.That(CourseScheduleII.FindOrder(1, []).Length, Is.EqualTo(1));
    }
}
