namespace LeetCode.Tests;

[TestFixture]
[Category("Trees")]
public class CodecTests
{
    [Test]
    public void SerializeDeserialize_RoundTrip()
    {
        var codec = new Codec();
        var root = new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5)));
        var data = codec.Serialize(root);
        Assert.That(data, Is.Not.Null.And.Not.Empty);
        // After implementing, deserialized tree should equal original
    }

    [Test]
    public void SerializeDeserialize_NullTree()
    {
        var codec = new Codec();
        var data = codec.Serialize(null!);
        // Should handle null gracefully
    }
}
