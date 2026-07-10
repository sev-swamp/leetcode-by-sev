namespace LeetCode.Tests;

[TestFixture]
[Category("Stack")]
public class AsteroidCollisionTests
{
    [Test]
    public void AsteroidCollisionSolution_SurvivesLarger()
    {
        Assert.That(AsteroidCollision.AsteroidCollisionSolution([5, 10, -5]), Is.EqualTo(new[] { 5, 10 }));
    }

    [Test]
    public void AsteroidCollisionSolution_BothExplode()
    {
        Assert.That(AsteroidCollision.AsteroidCollisionSolution([8, -8]), Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    public void AsteroidCollisionSolution_NoCollision()
    {
        Assert.That(AsteroidCollision.AsteroidCollisionSolution([-2, -1, 1, 2]), Is.EqualTo(new[] { -2, -1, 1, 2 }));
    }

    [Test]
    public void AsteroidCollisionSolution_ChainCollision()
    {
        Assert.That(AsteroidCollision.AsteroidCollisionSolution([10, 2, -5]), Is.EqualTo(new[] { 10 }));
    }
}
