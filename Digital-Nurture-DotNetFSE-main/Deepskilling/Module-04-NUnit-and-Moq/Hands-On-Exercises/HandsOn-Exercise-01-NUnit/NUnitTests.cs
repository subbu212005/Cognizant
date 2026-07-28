using NUnit.Framework;

namespace NUnitHandsOn
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [OneTimeSetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(15, 25, 40)]
        public void Add_Test(int a, int b, int expected)
        {
            int result = calculator.Add(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_Test()
        {
            int result = calculator.Divide(20, 5);

            Assert.AreEqual(4, result);
        }
    }
}