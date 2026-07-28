using NUnit.Framework;
using System.Collections;

namespace FourSeasonsLib.Tests
{
    public class FourSeasons
    {
        public string GetSeason(string month)
        {
            switch (month.ToLower())
            {
                case "february":
                case "march":
                    return "Spring";

                case "april":
                case "may":
                case "june":
                    return "Summer";

                case "july":
                case "august":
                case "september":
                    return "Monsoon";

                case "october":
                case "november":
                    return "Autumn";

                case "december":
                case "january":
                    return "Winter";

                default:
                    return "Invalid Month";
            }
        }
    }

    [TestFixture]
    public class FourSeasonsTests
    {
        private FourSeasons seasons;

        [SetUp]
        public void Setup()
        {
            seasons = new FourSeasons();
        }

        public static IEnumerable SeasonTestCases
        {
            get
            {
                yield return new TestCaseData("February", "Spring");
                yield return new TestCaseData("May", "Summer");
                yield return new TestCaseData("August", "Monsoon");
                yield return new TestCaseData("October", "Autumn");
                yield return new TestCaseData("December", "Winter");
            }
        }

        [Test]
        [TestCaseSource(nameof(SeasonTestCases))]
        public void GetSeason_ValidMonth_ReturnsExpectedSeason(string month, string expected)
        {
            string result = seasons.GetSeason(month);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}