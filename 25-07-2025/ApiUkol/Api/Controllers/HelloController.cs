using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello World");
        }

        [HttpGet("Echo")]
        public IActionResult Echo([FromQuery] string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return BadRequest("Zpráva nesmí být prázdná");
            }
            return Ok($"Echo: {message}");
        }

        [HttpGet("time")]
        public IActionResult GetCurrentTime()
        {
            var currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return Ok($"Aktuální čas: {currentTime}");
        }
    }
}
