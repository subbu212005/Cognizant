using NUnit.Framework;
using Moq;

namespace ConverterLib.Tests
{
    public interface IDollarToEuroExchangeRateFeed
    {
        decimal GetExchangeRate();
    }

    public class Converter
    {
        private readonly IDollarToEuroExchangeRateFeed exchangeRateFeed;

        public Converter(IDollarToEuroExchangeRateFeed feed)
        {
            exchangeRateFeed = feed;
        }

        public decimal USDToEuro(decimal dollars)
        {
            return dollars * exchangeRateFeed.GetExchangeRate();
        }
    }

    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void USDToEuro_ValidInput_ReturnsConvertedValue()
        {
            var mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();

            mockFeed.Setup(x => x.GetExchangeRate())
                    .Returns(0.92m);

            Converter converter = new Converter(mockFeed.Object);

            decimal result = converter.USDToEuro(100);

            Assert.That(result, Is.EqualTo(92));
        }

        [Test]
        public void USDToEuro_ZeroInput_ReturnsZero()
        {
            var mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();

            mockFeed.Setup(x => x.GetExchangeRate())
                    .Returns(0.92m);

            Converter converter = new Converter(mockFeed.Object);

            decimal result = converter.USDToEuro(0);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void USDToEuro_LargeValue_ReturnsExpectedResult()
        {
            var mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();

            mockFeed.Setup(x => x.GetExchangeRate())
                    .Returns(0.92m);

            Converter converter = new Converter(mockFeed.Object);

            decimal result = converter.USDToEuro(500);

            Assert.That(result, Is.EqualTo(460));
        }
    }
}