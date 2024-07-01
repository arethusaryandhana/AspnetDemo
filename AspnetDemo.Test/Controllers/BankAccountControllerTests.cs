using AspnetDemo.Controllers;
using AspnetDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AspnetDemo.Test.Controllers
{
	[TestClass]
	public class BankAccountControllerTests
	{
		private Mock<IBankAccountService> _mockBankAccountService;
		private BankAccountController _controller;

		[TestInitialize]
		public void Setup()
		{
			_mockBankAccountService = new Mock<IBankAccountService>();
			_controller = new BankAccountController(_mockBankAccountService.Object);
		}
		[TestMethod]
		public void Balance_ReturnsOkResult_WithCorrectSum()
		{
			// Arrange
			int expectedSum = 1000000;
			_mockBankAccountService.Setup(service => service.Balance()).Returns(expectedSum);

			// Act
			var result = _controller.Balance() as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedSum, result.Value);
		}
		[TestMethod]
		public void Depositing_ReturnsOkResult_WithCorrectSum()
		{
			// Arrange
			int a = 500000, expectedSum = 1500000;
			_mockBankAccountService.Setup(service => service.Depositing(a)).Returns(expectedSum);

			// Act
			var result = _controller.Depositing(a) as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedSum, result.Value);
		}
		[TestMethod]
		public void WithDrawing_ReturnsOkResult_WithCorrectSum()
		{
			// Arrange
			int a = 500000, expectedSum = 500000;
			_mockBankAccountService.Setup(service => service.WithDrawing(a)).Returns(expectedSum);

			// Act
			var result = _controller.WithDrawing(a) as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedSum, result.Value);
		}
	}
}
