using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCalculatorLib.Tests
{
    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator calculator = null!;

        [SetUp]
        public void Init()
        {
            calculator = new LeapYearCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null!;
        }

        [TestCase(2000, 1)]
        [TestCase(2024, 1)]
        [TestCase(1900, 0)]
        [TestCase(2023, 0)]
        [TestCase(1752, -1)]
        [TestCase(10000, -1)]
        [TestCase(1753, 0)]
        [TestCase(9999, 0)]
        public void CheckLeapYear_VariousYears_ReturnsExpectedOutcome(int year, int expectedOutcome)
        {
            // Act
            int actualOutcome = calculator.CheckLeapYear(year);

            // Assert
            Assert.That(actualOutcome, Is.EqualTo(expectedOutcome));
        }
    }
}
