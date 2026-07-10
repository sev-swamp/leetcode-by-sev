namespace LeetCode.Tests;

[TestFixture]
[Category("Arrays")]
public class RotateImageTests
{
    [Test]
    public void Rotate_3x3()
    {
        int[][] m = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        RotateImage.Rotate(m);
        Assert.That(m, Is.EqualTo(new[] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } }));
    }

    [Test]
    public void Rotate_2x2()
    {
        int[][] m = [[1, 2], [3, 4]];
        RotateImage.Rotate(m);
        Assert.That(m, Is.EqualTo(new[] { new[] { 3, 1 }, new[] { 4, 2 } }));
    }
}
