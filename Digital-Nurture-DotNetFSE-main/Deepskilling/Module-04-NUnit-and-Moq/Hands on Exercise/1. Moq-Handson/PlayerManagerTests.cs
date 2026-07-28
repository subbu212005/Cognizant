using NUnit.Framework;
using Moq;
using System;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerManagerTests
    {
        private Mock<IPlayerMapper> _mockPlayerMapper = null!;

        [OneTimeSetUp]
        public void Init()
        {
            _mockPlayerMapper = new Mock<IPlayerMapper>();
        }

        [TestCase("Dhoni")]
        public void RegisterNewPlayer_ValidPlayer_ShouldRegisterAndReturnPlayer(string name)
        {
            // When the RegisterNewPlayer function calls IsPlayerNameExistsInDb,
            // we configure the mock object to return "false".
            _mockPlayerMapper
                .Setup(x => x.IsPlayerNameExistsInDb(name))
                .Returns(false);

            _mockPlayerMapper
                .Setup(x => x.AddNewPlayerIntoDb(name));

            // Act
            Player player = Player.RegisterNewPlayer(name, _mockPlayerMapper.Object);

            // Assert various player attributes
            Assert.That(player, Is.Not.Null);
            Assert.That(player.Name, Is.EqualTo(name));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));

            // Verify that the mock methods were called as expected
            _mockPlayerMapper.Verify(x => x.IsPlayerNameExistsInDb(name), Times.Once);
            _mockPlayerMapper.Verify(x => x.AddNewPlayerIntoDb(name), Times.Once);
        }

        [TestCase("ExistingPlayer")]
        [ExpectedException(typeof(ArgumentException))]
        public void RegisterNewPlayer_NameAlreadyExists_ThrowsException(string name)
        {
            // Configure the mock object to return true to simulate name existence in Db
            _mockPlayerMapper
                .Setup(x => x.IsPlayerNameExistsInDb(name))
                .Returns(true);

            // Act (should throw ArgumentException, caught and verified by ExpectedExceptionAttribute)
            Player.RegisterNewPlayer(name, _mockPlayerMapper.Object);
        }
    }
}
