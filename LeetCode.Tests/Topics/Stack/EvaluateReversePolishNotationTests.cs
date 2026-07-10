namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class EvaluateReversePolishNotationTests
{
    [Test]
    public void EvalRPN_AddThenMultiply()
    {
        Assert.That(EvaluateReversePolishNotation.EvalRPN(["2", "1", "+", "3", "*"]), Is.EqualTo(9));
    }

    [Test]
    public void EvalRPN_DivisionThenAdd()
    {
        Assert.That(EvaluateReversePolishNotation.EvalRPN(["4", "13", "5", "/", "+"]), Is.EqualTo(6));
    }

    [Test]
    public void EvalRPN_Complex()
    {
        Assert.That(EvaluateReversePolishNotation.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]), Is.EqualTo(22));
    }
}
