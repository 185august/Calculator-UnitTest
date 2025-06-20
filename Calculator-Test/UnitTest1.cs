using Calculator_Console;

namespace Calculator_Test;

public class Tests
{
    private Calculator _calculator;
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void TestAddition()
    {
        Assert.That(_calculator.Addition(4, 5), Is.EqualTo(9));
    }
    [Test]
    public void TestSubtraction()
    {
            
        Assert.That(_calculator.Subtract(10, 5), Is.EqualTo(5));
    }
    [Test]
    public void TestMultiplication()
    {
        Assert.That(_calculator.Multiply(4, 5), Is.EqualTo(20));
    }
    [Test]
    public void TestDivision()
    {
        Assert.That(_calculator.Divide(10, 2), Is.EqualTo(5));
    }
    [Test]
    public void TestDivisionByZero()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
    }
    [Test]
    public void TestNegativeNumbers()
    {
        Assert.That(_calculator.Addition(-4, -5), Is.EqualTo(-9));
        Assert.That(_calculator.Subtract(-10, -5), Is.EqualTo(-5));
        Assert.That(_calculator.Multiply(-4, -5), Is.EqualTo(20));
        Assert.That(_calculator.Divide(-10, -2), Is.EqualTo(5));
    }
    [Test]
    public void TestNegativeNumbersByZero()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Divide(-10, 0));
    }
}