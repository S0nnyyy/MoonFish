using Microsoft.AspNetCore.Mvc;
using Ukol8.Models;

namespace PersonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person dto)
        {
            if (!ModelState.IsValid)
            {         
                HttpContext.Items["ModelState"] = ModelState;
                return BadRequest(); 
            }

            return Ok(new { message = "Osoba úspìšnì vytvoøena" });
        }
    }
}
