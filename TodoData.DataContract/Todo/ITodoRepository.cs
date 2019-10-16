using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoWebApi.DataContract.Todo
{
    public interface ITodoRepository
    {
        Task<bool> CreateTodo(TodoCreateRAO rao);
        Task<IEnumerable<TodoGetListItemRAO>> GetTodos();
        Task<TodoGetListItemRAO> GetTodoById(int id);
        Task<bool> UpdateTodo(TodoUpdateRAO rao);
        Task<bool> DeleteTodo(int id);
    }
}
