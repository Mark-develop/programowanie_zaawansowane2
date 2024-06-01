using Moq;
using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldSendDataToWebService()
        {
            // Arrange
            var webServiceMock = new Mock<IWebService>();
            var calculator = new Calculator(webServiceMock.Object);

            // Act
            int result = calculator.Add(3, 5);

            // Assert
            Assert.AreEqual(8, result);

            // Verify that the SendData method was called with the expected argument
            webServiceMock.Verify(ws => ws.SendData("Add operation: 3 + 5 = 8"), Times.Once);
        }
    }
}
