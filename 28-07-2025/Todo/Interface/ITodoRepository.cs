using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Interface
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem? GetById(Guid id);
        void Add(TodoItem item);
        void Update(TodoItem item);
        void Delete(Guid id);

    }
}
