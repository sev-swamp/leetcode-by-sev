namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class GenerateParenthesesTests
{
    [Test]
    public void GenerateParenthesis_N3()
    {
        var result = GenerateParentheses.GenerateParenthesis(3);
        Assert.That(result.Count, Is.EqualTo(5));
        Assert.That(result, Has.Member("((()))"));
        Assert.That(result, Has.Member("()()()"));
    }

    [Test]
    public void GenerateParenthesis_N1()
    {
        var result = GenerateParentheses.GenerateParenthesis(1);
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result[0], Is.EqualTo("()"));
    }
}
