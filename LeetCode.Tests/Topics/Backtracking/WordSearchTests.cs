namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class WordSearchTests
{
    [Test]
    public void Exist_WordFound()
    {
        char[][] b = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        Assert.That(WordSearch.Exist(b, "ABCCED"), Is.True);
        Assert.That(WordSearch.Exist(b, "SEE"), Is.True);
    }

    [Test]
    public void Exist_WordNotFound()
    {
        char[][] b = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        Assert.That(WordSearch.Exist(b, "ABCB"), Is.False);
    }
}
