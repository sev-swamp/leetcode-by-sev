namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class CourseScheduleTests
{
    [Test]
    public void CanFinish_NoCycle()
    {
        Assert.That(CourseSchedule.CanFinish(2, [[1, 0]]), Is.True);
    }

    [Test]
    public void CanFinish_HasCycle()
    {
        Assert.That(CourseSchedule.CanFinish(2, [[1, 0], [0, 1]]), Is.False);
    }

    [Test]
    public void CanFinish_NoPrerequisites()
    {
        Assert.That(CourseSchedule.CanFinish(1, []), Is.True);
    }
}
