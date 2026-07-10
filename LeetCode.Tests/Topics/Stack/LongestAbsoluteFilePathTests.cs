namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class LongestAbsoluteFilePathTests
{
    [TestCase("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext",            ExpectedResult = 20)]
    [TestCase("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext", ExpectedResult = 32)]
    public int LengthLongestPath(string input) =>
        LongestAbsoluteFilePath.LengthLongestPath(input);
}
