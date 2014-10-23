using NUnit.Framework;

[TestFixture]
public class ExampleTests
{
    [TestCase(2, 2, 4)]
    [TestCase(12, 24, 36)]
    [TestCase(100, 1, 101)]
    [TestCase(2, -2, 0)]
    public void Can_add(int x, int y, int expected)
    {
        Assert.That(Example.Add(x, y), Is.EqualTo(expected));
    }
}
