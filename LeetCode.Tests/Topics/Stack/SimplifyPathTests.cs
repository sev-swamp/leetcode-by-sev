namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class SimplifyPathTests
{
    [TestCase("/home/",          ExpectedResult = "/home")]
    [TestCase("/../",            ExpectedResult = "/")]
    [TestCase("/home//foo/",     ExpectedResult = "/home/foo")]
    [TestCase("/a/./b/../../c/", ExpectedResult = "/c")]
    public string SimplifyPathSolution(string path) =>
        SimplifyPath.SimplifyPathSolution(path);
}
