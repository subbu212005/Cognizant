using NUnit.Framework;
using System;

namespace NUnitHandsOn
{
    public class Calculator
    {
        private int result;

        public int Add(int a, int b)
        {
            result = a + b;
            return result;
        }

        public int Subtract(int a, int b)
        {
            result = a - b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Division by zero");

            result = a / b;
            return result;
        }

        public void AllClear()
        {
            result = 0;
        }

        public int GetResult
        {
            get { return result; }
        }
    }

    [TestFixture]
    public class MathLibraryTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // Parameterized Test - Subtraction
        [TestCase(10, 5, 5)]
        [TestCase(20, 8, 12)]
        [TestCase(50, 25, 25)]
        [TestCase(100, 60, 40)]
        public void TestSubtract(int a, int b, int expected)
        {
            int actual = calculator.Subtract(a, b);

            Assert.AreEqual(expected, actual);
        }

        // Parameterized Test - Multiplication
        [TestCase(2, 5, 10)]
        [TestCase(3, 4, 12)]
        [TestCase(5, 5, 25)]
        [TestCase(10, 10, 100)]
        public void TestMultiply(int a, int b, int expected)
        {
            int actual = calculator.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        // Parameterized Test - Division
        [TestCase(20, 5, 4)]
        [TestCase(100, 20, 5)]
        [TestCase(81, 9, 9)]
        public void TestDivide(int a, int b, int expected)
        {
            int actual = calculator.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        // Exception Test
        [Test]
        public void TestDivideByZero()
        {
            try
            {
                calculator.Divide(20, 0);

                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Division by zero", ex.Message);
            }
        }

        // Void Method Test
        [Test]
        public void TestAddAndClear()
        {
            calculator.Add(15, 25);

            Assert.AreEqual(40, calculator.GetResult);

            calculator.AllClear();

            Assert.AreEqual(0, calculator.GetResult);
        }
    }
}