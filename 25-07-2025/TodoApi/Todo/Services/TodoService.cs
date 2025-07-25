

using Todo.Models;

namespace Todo.Services
{
    public class TodoService
    {
        private static readonly List<TodoItem> _todos = new()
        {
            new TodoItem
            {
                Id = Guid.NewGuid(),
                Title = "Task 1",
                Description = "This is the first task",
                IsCompleted = false,
                CreatedAt = DateTime.UtcNow,
                CompletedAt = null
            }
        };

        public IEnumerable<TodoItem> GetAll() => _todos;

        public TodoItem? GetById(Guid id) =>
            _todos.FirstOrDefault(t => t.Id == id);

        public TodoItem Create(TodoItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            newItem.CreatedAt = DateTime.UtcNow;
            if (newItem.IsCompleted && newItem.CompletedAt == null)
            {
                newItem.CompletedAt = DateTime.UtcNow;
            }

            _todos.Add(newItem);
            return newItem;
        }

        public TodoItem? MarkAsCompleted(Guid id)
        {
            var item = GetById(id);
            if (item == null || item.IsCompleted)
                return item;

            item.IsCompleted = true;
            item.CompletedAt = DateTime.UtcNow;
            return item;
        }

        public bool Delete(Guid id)
        {
            var item = GetById(id);
            if (item == null)
                return false;

            _todos.Remove(item);
            return true;
        }
    }
}
