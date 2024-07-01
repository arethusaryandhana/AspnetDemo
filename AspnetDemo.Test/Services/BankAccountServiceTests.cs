using AspnetDemo.Services;

namespace AspnetDemo.Test.Services
{
	[TestClass]
	public class BankAccountServiceTests
	{
		private BankAccountService _bankAccountService;

		[TestInitialize]
		public void Setup()
		{
			_bankAccountService = new BankAccountService();
		}

		[TestMethod]
		public void Balance_ReturnsCorrectSum()
		{
			int result = _bankAccountService.Balance();
			Assert.AreEqual(1000000, result);
		}

		[TestMethod]
		public void Depositing_ReturnsCorrectDifference()
		{
			int result = _bankAccountService.Depositing(500000);
			Assert.AreEqual(1500000, result);
		}
		[TestMethod]
		public void WithDrawing_ReturnsCorrectDifference()
		{
			int result = _bankAccountService.WithDrawing(500000);
			Assert.AreEqual(500000, result);
		}
	}
}
