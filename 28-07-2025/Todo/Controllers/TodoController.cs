using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Services;
using System;
using System.Collections.Generic;

namespace Todo.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _service;

        public TodoController(TodoService service)
        {
            _service = service;
        }

        [HttpGet("list")]
        public ActionResult<IEnumerable<TodoItem>> GetAll()
        {
            IEnumerable<TodoItem> items = _service.GetAll();
            return Ok(items);
        }

        [HttpPost("add")]
        public ActionResult<TodoItem> Create([FromBody] TodoItem newItem)
        {
            TodoItem createdItem = _service.Create(newItem);
            return CreatedAtAction(nameof(GetById), new { id = createdItem.Id }, createdItem);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(Guid id)
        {
            TodoItem item = _service.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(item);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<TodoItem> MarkAsCompleted(Guid id)
        {
            TodoItem updatedItem = _service.MarkAsCompleted(id);
            if (updatedItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(updatedItem);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            bool deleted = _service.Delete(id);
            if (deleted)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
