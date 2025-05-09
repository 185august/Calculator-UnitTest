using Calculator_Console;

namespace Calculator_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Addition(4, 5), Is.EqualTo(9));
        }
        [Test]
        public void TestSubtraction()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtract(10, 5), Is.EqualTo(5));
        }
        [Test]
        public void TestMultiplication()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiply(4, 5), Is.EqualTo(20));
        }
        [Test]
        public void TestDivision()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Divide(10, 2), Is.EqualTo(5));
        }
        [Test]
        public void TestDivisionByZero()
        {
            var calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }
        [Test]
        public void TestNegativeNumbers()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Addition(-4, -5), Is.EqualTo(-9));
            Assert.That(calculator.Subtract(-10, -5), Is.EqualTo(-5));
            Assert.That(calculator.Multiply(-4, -5), Is.EqualTo(20));
            Assert.That(calculator.Divide(-10, -2), Is.EqualTo(5));
        }
        [Test]
        public void TestNegativeNumbersByZero()
        {
            var calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Divide(-10, 0));
        }
    }
}
