using Microsoft.AspNetCore.Mvc;
using Ukol9.Models;

namespace Ukol9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PersonController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetPeople()
        {
            var people = _context.People.ToList();
            return Ok(people);
        }

        [HttpPost]
        public ActionResult<Person> CreatePerson([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Person data is null.");
            }
            _context.People.Add(person);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPeople), new { id = person.Id }, person);
        }

    }
}
