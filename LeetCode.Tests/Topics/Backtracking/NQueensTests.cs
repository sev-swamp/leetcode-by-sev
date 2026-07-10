namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class NQueensTests
{
    [Test]
    public void SolveNQueens_N4()
    {
        Assert.That(NQueens.SolveNQueens(4).Count, Is.EqualTo(2));
    }

    [Test]
    public void SolveNQueens_N1()
    {
        var r = NQueens.SolveNQueens(1);
        Assert.That(r.Count, Is.EqualTo(1));
        Assert.That(r[0][0], Is.EqualTo("Q"));
    }
}
