using NUnit.Framework;
using System;

namespace UserManagerLib.Tests
{
    public class UserManager
    {
        public string CreateUser(string panCardNo)
        {
            if (string.IsNullOrWhiteSpace(panCardNo))
                throw new NullReferenceException("PAN Card is mandatory");

            if (panCardNo.Length != 10)
                throw new FormatException("PAN Card must contain exactly 10 characters");

            return "User Created Successfully";
        }
    }

    [TestFixture]
    public class UserManagerTests
    {
        private UserManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new UserManager();
        }

        // Happy Path
        [Test]
        public void CreateUser_ValidPanCard_ReturnsSuccess()
        {
            string result = manager.CreateUser("ABCDE1234F");

            Assert.That(result, Is.EqualTo("User Created Successfully"));
        }

        // Null PAN Card
        [Test]
        public void CreateUser_NullPanCard_ThrowsNullReferenceException()
        {
            Assert.That(() => manager.CreateUser(null),
                Throws.TypeOf<NullReferenceException>());
        }

        // Empty PAN Card
        [Test]
        public void CreateUser_EmptyPanCard_ThrowsNullReferenceException()
        {
            Assert.That(() => manager.CreateUser(""),
                Throws.TypeOf<NullReferenceException>());
        }

        // Less than 10 Characters
        [Test]
        public void CreateUser_InvalidLength_ThrowsFormatException()
        {
            Assert.That(() => manager.CreateUser("ABC123"),
                Throws.TypeOf<FormatException>());
        }

        // Greater than 10 Characters
        [Test]
        public void CreateUser_GreaterLength_ThrowsFormatException()
        {
            Assert.That(() => manager.CreateUser("ABCDE12345FG"),
                Throws.TypeOf<FormatException>());
        }
    }
}