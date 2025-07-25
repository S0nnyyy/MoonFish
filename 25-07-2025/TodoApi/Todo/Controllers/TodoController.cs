using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Services;

namespace Todo.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("list")]
        public ActionResult<IEnumerable<TodoItem>> GetAll()
        {
            return Ok(_todoService.GetAll());
        }

        [HttpPost("add")]
        public ActionResult<TodoItem> Create([FromBody] TodoItem newItem)
        {
            var createdItem = _todoService.Create(newItem);
            return CreatedAtAction(nameof(GetById), new { id = createdItem.Id }, createdItem);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(Guid id)
        {
            var item = _todoService.GetById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPatch("{id}")]
        public ActionResult<TodoItem> MarkAsCompleted(Guid id)
        {
            var item = _todoService.MarkAsCompleted(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var result = _todoService.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
