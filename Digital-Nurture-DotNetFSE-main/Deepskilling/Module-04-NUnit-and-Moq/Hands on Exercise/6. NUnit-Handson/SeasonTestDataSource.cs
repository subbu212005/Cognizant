using System.Collections;
using NUnit.Framework;

namespace FourSeasonsLib.Tests
{
    public class SeasonTestDataSource
    {
        // Alternate Way A: IEnumerable returning TestCaseData from an external class
        public static IEnumerable SeasonTestData
        {
            get
            {
                yield return new TestCaseData("January", "Winter");
                yield return new TestCaseData("February", "Spring");
                yield return new TestCaseData("March", "Spring");
                yield return new TestCaseData("April", "Summer");
                yield return new TestCaseData("May", "Summer");
                yield return new TestCaseData("June", "Summer");
                yield return new TestCaseData("July", "Monsoon");
                yield return new TestCaseData("August", "Monsoon");
                yield return new TestCaseData("September", "Monsoon");
                yield return new TestCaseData("October", "Autumn");
                yield return new TestCaseData("November", "Autumn");
                yield return new TestCaseData("December", "Winter");
            }
        }

        // Alternate Way B: Static object[] array from an external class
        public static object[] AlternateSeasonTestData =
        {
            new object[] { "January", "Winter" },
            new object[] { "February", "Spring" },
            new object[] { "March", "Spring" },
            new object[] { "April", "Summer" },
            new object[] { "May", "Summer" },
            new object[] { "June", "Summer" },
            new object[] { "July", "Monsoon" },
            new object[] { "August", "Monsoon" },
            new object[] { "September", "Monsoon" },
            new object[] { "October", "Autumn" },
            new object[] { "November", "Autumn" },
            new object[] { "December", "Winter" }
        };
    }
}
