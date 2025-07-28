using Todo.Interface;
using Todo.Models;

namespace Todo.Repositories
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private readonly List<TodoItem> _todos = new();

        public InMemoryTodoRepository()
        {
            // Testovací data pro InMemoryTodoRepository.
            _todos.Add(new TodoItem { Id = Guid.NewGuid(), Title = "První úkol", IsCompleted = false, CreatedAt = DateTime.Now });
            _todos.Add(new TodoItem { Id = Guid.NewGuid(), Title = "Druhý úkol", IsCompleted = false, CreatedAt = DateTime.Now });
        }

        // Vrací všechny položky Todo z paměti.
        public IEnumerable<TodoItem> GetAll() => _todos;

        // Vrací položku Todo podle ID, nebo null, pokud neexistuje.
        public TodoItem? GetById(Guid id) =>
            _todos.FirstOrDefault(t => t.Id == id);

        //Přidává novou položku Todo do paměti.
        public void Add(TodoItem item) =>
            _todos.Add(item);

        // Aktualizuje existující položku Todo v paměti.
        public void Update(TodoItem item)
        {
            var index = _todos.FindIndex(t => t.Id == item.Id);
            if (index != -1)
                _todos[index] = item;
        }
        // Odstraňuje položku Todo z paměti podle ID.
        public void Delete(Guid id)
        {
            var item = GetById(id);
            if (item != null)
                _todos.Remove(item);
        }
    }
}
