using AspnetDemo.Controllers;
using AspnetDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AspnetDemo.Test.Controllers
{
	[TestClass]
	public class CalculatorControllerTests
	{
		private Mock<ICalculatorService> _mockCalculatorService;
		private CalculatorController _controller;

		[TestInitialize]
		public void Setup()
		{
			_mockCalculatorService = new Mock<ICalculatorService>();
			_controller = new CalculatorController(_mockCalculatorService.Object);
		}

		[TestMethod]
		public void Add_ReturnsOkResult_WithCorrectSum()
		{
			// Arrange
			int a = 2, b = 3, expectedSum = 5;
			_mockCalculatorService.Setup(service => service.Add(a, b)).Returns(expectedSum);

			// Act
			var result = _controller.Add(a, b) as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedSum, result.Value);
		}

		[TestMethod]
		public void Subtract_ReturnsOkResult_WithCorrectDifference()
		{
			// Arrange
			int a = 5, b = 3, expectedDifference = 2;
			_mockCalculatorService.Setup(service => service.Subtract(a, b)).Returns(expectedDifference);

			// Act
			var result = _controller.Subtract(a, b) as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedDifference, result.Value);
		}
		[TestMethod]
		public void Multiply_ReturnsOkResult_WithCorrectDifference()
		{
			// Arrange
			int a = 5, b = 3, expectedDifference = 15;
			_mockCalculatorService.Setup(service => service.Multiply(a, b)).Returns(expectedDifference);

			// Act
			var result = _controller.Multiply(a, b) as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedDifference, result.Value);
		}
		[TestMethod]
		public void Divide_ReturnsOkResult_WithCorrectDifference()
		{
			// Arrange
			int a = 6, b = 3, expectedDifference = 2;
			_mockCalculatorService.Setup(service => service.Divide(a, b)).Returns(expectedDifference);

			// Act
			var result = _controller.Divide(a, b) as OkObjectResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(200, result.StatusCode);
			Assert.AreEqual(expectedDifference, result.Value);
		}
	}
}
