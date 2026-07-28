using NUnit.Framework;

namespace LeapYearCalculatorLib.Tests
{
    public class LeapYearCalculator
    {
        public int CheckLeapYear(int year)
        {
            if (year < 1753 || year > 9999)
                return -1;

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return 1;

            return 0;
        }
    }

    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new LeapYearCalculator();
        }

        [TestCase(2024, 1)]
        [TestCase(2023, 0)]
        [TestCase(2000, 1)]
        [TestCase(1900, 0)]
        [TestCase(1700, -1)]
        [TestCase(10000, -1)]
        public void CheckLeapYear_ValidInput_ReturnsExpectedResult(int year, int expected)
        {
            int result = calculator.CheckLeapYear(year);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}