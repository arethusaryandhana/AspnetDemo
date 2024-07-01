using AspnetDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspnetDemo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BankAccountController : ControllerBase
	{
		private readonly IBankAccountService _bankAccountService;
		public BankAccountController(IBankAccountService bankAccountService)
		{
			_bankAccountService = bankAccountService;
		}
		[HttpGet("bankAmount")]
		public IActionResult Balance()
		{
			var result = _bankAccountService.Balance();
			return Ok(result);
		}
		[HttpGet("depositing")]
		public IActionResult Depositing(int a)
		{
			var result = _bankAccountService.Depositing(a);
			return Ok(result);
		}
		[HttpGet("withDrawing")]
		public IActionResult WithDrawing(int a)
		{
			var result = _bankAccountService.WithDrawing(a);
			return Ok(result);
		}
	}
}
