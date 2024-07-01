using AspnetDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspnetDemo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CalculatorController : ControllerBase
	{
		private readonly ICalculatorService _calculatorService;

		public CalculatorController(ICalculatorService calculatorService)
		{
			_calculatorService = calculatorService;
		}

		[HttpGet("add")]
		public IActionResult Add(int a, int b)
		{
			var result = _calculatorService.Add(a, b);
			return Ok(result);
		}

		[HttpGet("subtract")]
		public IActionResult Subtract(int a, int b)
		{
			var result = _calculatorService.Subtract(a, b);
			return Ok(result);
		}
		[HttpGet("multiply")]
		public IActionResult Multiply(int a, int b)
		{
			var result = _calculatorService.Multiply(a, b);
			return Ok(result);
		}
		[HttpGet("divide")]
		public IActionResult Divide(int a, int b)
		{
			var result = _calculatorService.Divide(a, b);
			return Ok(result);
		}
	}
}
