using Microsoft.AspNetCore.Mvc;

namespace LambdaAspNetCoreMinimalApiTest.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CalculatorController : ControllerBase
	{
		private readonly ILogger<CalculatorController> _logger;

		public CalculatorController(ILogger<CalculatorController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Hello Calculator");
		}

		[HttpGet("add/{x}/{y}")]
		public IActionResult Add(int x, int y)
		{
			_logger.LogInformation($"{x} plus {y} is {x + y}");
			return Ok(x + y);
		}

		[HttpGet("subtract/{x}/{y}")]
		public IActionResult Subtract(int x, int y)
		{
			_logger.LogInformation($"{x} subtract {y} is {x - y}");
			return Ok(x - y);
		}

		[HttpGet("multiply/{x}/{y}")]
		public IActionResult Multiply(int x, int y)
		{
			_logger.LogInformation($"{x} multiply {y} is {x * y}");
			return Ok(x * y);
		}

		[HttpGet("divide/{x}/{y}")]
		public IActionResult Divide(int x, int y)
		{
			if (y == 0)
				return BadRequest();

			_logger.LogInformation($"{x} divide {y} is {x / y}");
			return Ok(x / y);
		}
	}
}
