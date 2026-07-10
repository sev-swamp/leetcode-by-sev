namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class RestoreIPAddressesTests
{
    [Test]
    public void RestoreIpAddresses_BasicCase()
    {
        var r = RestoreIPAddresses.RestoreIpAddresses("25525511135");
        Assert.That(r, Has.Member("255.255.11.135"));
        Assert.That(r, Has.Member("255.255.111.35"));
    }

    [Test]
    public void RestoreIpAddresses_TooShort()
    {
        Assert.That(RestoreIPAddresses.RestoreIpAddresses("0000"), Has.Member("0.0.0.0"));
    }
}
