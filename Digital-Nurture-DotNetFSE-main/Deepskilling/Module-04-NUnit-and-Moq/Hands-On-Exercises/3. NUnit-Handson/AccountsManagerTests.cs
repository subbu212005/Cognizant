using NUnit.Framework;

namespace UtilLib.Tests
{
    public class UrlHostNameParser
    {
        public string ParseHostName(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return null;

            if (!url.StartsWith("http"))
                return null;

            return new System.Uri(url).Host;
        }
    }

    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_ValidUrl_ReturnsHostName()
        {
            string result = parser.ParseHostName("https://www.google.com/search");

            Assert.That(result, Is.EqualTo("www.google.com"));
        }

        [Test]
        public void ParseHostName_InvalidUrl_ReturnsNull()
        {
            string result = parser.ParseHostName("google");

            Assert.That(result, Is.Null);
        }
    }
}