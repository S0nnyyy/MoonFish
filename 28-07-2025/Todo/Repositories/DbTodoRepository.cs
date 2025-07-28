using Todo.Interface;
using Todo.Models;
using Microsoft.EntityFrameworkCore;


namespace Todo.Repositories
{
    public class DbTodoRepository : ITodoRepository
    {
        private readonly AppDbContext _context;
        public DbTodoRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TodoItem> GetAll()
        {
            return _context.TodoItems.ToList();
        }
        public TodoItem? GetById(Guid id)
        {
            return _context.TodoItems.Find(id);
        }
        public void Add(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }
        public void Update(TodoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _context.TodoItems.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
