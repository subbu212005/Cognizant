using NUnit.Framework;

namespace NUnitGettingStarted;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_ReturnsCorrectResult()
    {
        var calc=new Calculator();
        Assert.That(calc.Add(2,3), Is.EqualTo(5));
    }

    [Test]
    public void Subtract_ReturnsCorrectResult()
    {
        var calc=new Calculator();
        Assert.That(calc.Subtract(5,3), Is.EqualTo(2));
    }
}
