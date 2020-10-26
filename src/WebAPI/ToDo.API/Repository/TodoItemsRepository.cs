using System.Collections.Generic;
using System.Linq;
using ToDo.API.Contracts;
using ToDo.API.Entities;

namespace ToDo.API.Repository
{
    internal class TodoItemsRepository : ITodoItemsRepository
    {
        private RepositoryContext _repositoryContext { get; set; }

        internal TodoItemsRepository(RepositoryContext context)
        {
            _repositoryContext = context;
        }

        public IEnumerable<TodoItem> FindAll()
        {
            return _repositoryContext.TodoItems.ToList();
        }

        public void Create(TodoItem todoItem)
        {
            _repositoryContext.TodoItems.Add(todoItem);
        }

        public void Update(TodoItem todoItem)
        {
            _repositoryContext.TodoItems.Update(todoItem);
        }

        public void Delete(TodoItem todoItem)
        {
            _repositoryContext.TodoItems.Remove(todoItem);
        }
    }
}