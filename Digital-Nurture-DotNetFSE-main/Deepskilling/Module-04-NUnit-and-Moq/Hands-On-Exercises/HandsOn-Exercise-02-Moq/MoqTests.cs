using Moq;
using NUnit.Framework;

namespace MoqHandsOn
{
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }

    public class CustomerComm
    {
        private readonly IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail(
                "customer@abc.com",
                "Transaction Successful"
            );

            return true;
        }
    }

    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mockMailSender;
        private CustomerComm customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();

            mockMailSender
                .Setup(x => x.SendMail(
                    It.IsAny<string>(),
                    It.IsAny<string>()))
                .Returns(true);

            customerComm =
                new CustomerComm(mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_Test()
        {
            bool result =
                customerComm.SendMailToCustomer();

            Assert.IsTrue(result);

            mockMailSender.Verify(
                x => x.SendMail(
                    It.IsAny<string>(),
                    It.IsAny<string>()),
                Times.Once
            );
        }
    }
}