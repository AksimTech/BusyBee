using System.Collections.Generic;
using ToDo.API.Entities;

namespace ToDo.API.Contracts
{
    internal interface ITodoItemsRepository {
        IEnumerable<TodoItem> FindAll();
        void Create(TodoItem todoItem);
        void Update(TodoItem todoItem);
        void Delete(TodoItem todoItem);
    }
}