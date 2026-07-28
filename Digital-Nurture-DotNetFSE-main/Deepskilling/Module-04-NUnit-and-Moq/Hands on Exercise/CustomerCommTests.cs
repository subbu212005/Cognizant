using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender = null!;
        private CustomerCommLib.CustomerComm _customerComm = null!;

        [OneTimeSetUp]
        public void Init()
        {
            _mockMailSender = new Mock<IMailSender>();

            // Configure the mock object in such a way that SendMail() method will 
            // accept any two string arguments and always return true when SendMailToCustomer() gets invoked.
            _mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            // Inject the mock dependency via Constructor Injection
            _customerComm = new CustomerCommLib.CustomerComm(_mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            // Act
            bool result = _customerComm.SendMailToCustomer();

            // Assert the return value to "true"
            Assert.That(result, Is.True);
        }
    }
}
