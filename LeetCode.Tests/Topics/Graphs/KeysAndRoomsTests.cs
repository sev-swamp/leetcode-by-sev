namespace LeetCode.Tests;

[TestFixture]
[Category("Graphs")]
public class KeysAndRoomsTests
{
    [Test]
    public void CanVisitAllRooms_CanVisitAll()
    {
        var rooms = new List<IList<int>> { new List<int> {1}, new List<int> {2}, new List<int> {3}, new List<int>() };
        Assert.That(KeysAndRooms.CanVisitAllRooms(rooms), Is.True);
    }

    [Test]
    public void CanVisitAllRooms_CannotVisitAll()
    {
        var rooms = new List<IList<int>> { new List<int> {1,3}, new List<int> {3,0,1}, new List<int> {2}, new List<int> {0} };
        Assert.That(KeysAndRooms.CanVisitAllRooms(rooms), Is.False);
    }
}
