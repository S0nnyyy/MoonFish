using MathApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MathApi.Controllers
{
    [ApiController]
    [Route("math")]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet("add")]
        public IActionResult Add([FromQuery] int a, [FromQuery] int b)
        {
            var result = _mathService.Add(a, b);
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] int a, [FromQuery] int b)
        {
            var result = _mathService.Multiply(a, b);
            return Ok(result);
        }

        [HttpGet("random")]
        public IActionResult Random()
        {
            var number = _mathService.GenerateRandom();
            return Ok(number);
        }
    }
}
