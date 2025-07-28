using Todo.Interface;
using Todo.Models;
using System;
using System.Collections.Generic;

namespace Todo.Services
{
    public class TodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TodoItem> GetAll()
        {
            IEnumerable<TodoItem> items = _repository.GetAll();
            return items;
        }

        public TodoItem? GetById(Guid id)
        {
            TodoItem? item = _repository.GetById(id);
            return item;
        }

        public TodoItem Create(TodoItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            newItem.CreatedAt = DateTime.Now;

            if (newItem.IsCompleted && newItem.CompletedAt == null)
            {
                newItem.CompletedAt = DateTime.Now;
            }

            _repository.Add(newItem);
            return newItem;
        }

        public TodoItem? MarkAsCompleted(Guid id)
        {
            TodoItem? item = _repository.GetById(id);

            if (item == null)
            {
                return null;
            }

            if (item.IsCompleted)
            {
                return item;
            }

            item.IsCompleted = true;
            item.CompletedAt = DateTime.UtcNow;
            _repository.Update(item);
            return item;
        }

        public bool Delete(Guid id)
        {
            TodoItem? item = _repository.GetById(id);

            if (item == null)
            {
                return false;
            }

            _repository.Delete(id);
            return true;
        }
    }
}
