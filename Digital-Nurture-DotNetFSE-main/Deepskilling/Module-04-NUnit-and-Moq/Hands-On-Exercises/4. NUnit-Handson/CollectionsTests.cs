using NUnit.Framework;
using System;

namespace AccountsManagerLib.Tests
{
    public class AccountsManager
    {
        public string Login(string userId, string password)
        {
            if (string.IsNullOrWhiteSpace(userId) ||
                string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("UserId or Password cannot be empty");

            if ((userId == "user_11" && password == "secret@user11") ||
                (userId == "user_22" && password == "secret@user22"))
            {
                return $"Welcome {userId}!!!";
            }

            return "Invalid user id/password";
        }
    }

    [TestFixture]
    public class AccountsManagerTests
    {
        private AccountsManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new AccountsManager();
        }

        [Test]
        public void Login_ValidCredentials_ReturnsWelcomeMessage()
        {
            string result = manager.Login("user_11", "secret@user11");

            Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsInvalidMessage()
        {
            string result = manager.Login("admin", "admin123");

            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void Login_EmptyUserId_ThrowsArgumentException()
        {
            Assert.That(() => manager.Login("", "secret@user11"),
                Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            Assert.That(() => manager.Login("user_11", ""),
                Throws.TypeOf<ArgumentException>());
        }
    }
}