using AspnetDemo.Services;

namespace AspnetDemo.Test.Services
{
	[TestClass]
	public class CalculatorServiceTests
	{
		private CalculatorService _calculatorService;

		[TestInitialize]
		public void Setup()
		{
			_calculatorService = new CalculatorService();
		}

		[TestMethod]
		public void Add_ReturnsCorrectSum()
		{
			int result = _calculatorService.Add(2, 3);
			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void Subtract_ReturnsCorrectDifference()
		{
			int result = _calculatorService.Subtract(5, 3);
			Assert.AreEqual(2, result);
		}
		[TestMethod]
		public void Multiply_ReturnsCorrectDifference()
		{
			int result = _calculatorService.Multiply(5, 3);
			Assert.AreEqual(15, result);
		}
		[TestMethod]
		public void Divide_ReturnsCorrectDifference()
		{
			int result = _calculatorService.Divide(6, 3);
			Assert.AreEqual(2, result);
		}
	}
}
