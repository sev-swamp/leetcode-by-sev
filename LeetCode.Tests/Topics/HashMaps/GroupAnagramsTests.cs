namespace LeetCode.Tests;

[TestFixture]
[Category("HashMaps")]
public class GroupAnagramsTests
{
    [Test]
    public void GroupAnagramsSolution_BasicCase()
    {
        var result = GroupAnagrams.GroupAnagramsSolution(["eat", "tea", "tan", "ate", "nat", "bat"]);
        Assert.That(result.Count, Is.EqualTo(3));
    }

    [Test]
    public void GroupAnagramsSolution_SingleChar()
    {
        var result = GroupAnagrams.GroupAnagramsSolution([""]);
        Assert.That(result.Count, Is.EqualTo(1));
    }
}
