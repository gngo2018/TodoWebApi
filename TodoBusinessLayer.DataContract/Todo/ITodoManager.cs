using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoBusinessLayer.DataContract.Todo
{
    public interface ITodoManager
    {
        Task<bool> CreateTodo(TodoCreateDTO dto);
        Task<IEnumerable<TodoGetListItemDTO>> GetTodos();
        Task<TodoGetListItemDTO> GetTodoById(int id);
        Task<bool> UpdateTodo(TodoUpdateDTO dto);
        Task<bool> DeleteTodo(int id);
    }
}
