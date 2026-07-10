namespace LeetCode.Tests;

[TestFixture]
[Category("Heap")]
public class TaskSchedulerTests
{
    [TestCase(new[] {'A','A','A','B','B','B'}, 2, ExpectedResult = 8)]
    [TestCase(new[] {'A','A','A','B','B','B'}, 0, ExpectedResult = 6)]
    [TestCase(new[] {'A','A','A','A','A','A','B','C','D','E','F','G'}, 2, ExpectedResult = 16)]
    public int LeastInterval(char[] tasks, int n) =>
        TaskScheduler.LeastInterval(tasks, n);
}
