using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoData.DataContext;
using TodoData.Entities;
using TodoWebApi.DataContract.Todo;

namespace TodoData.Todo
{
    public class TodoRepository : ITodoRepository
    {
        private readonly IMapper _mapper;
        private readonly TodoContext _context;

        public TodoRepository(IMapper mapper, TodoContext context)
        {
            _mapper = mapper;
            _context = context;
            
        }

        public async Task<bool> CreateTodo(TodoCreateRAO rao)
        {
            var entity = _mapper.Map<TodoDataModel>(rao);

            await _context.Todo.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<TodoGetListItemRAO>> GetTodos()
        {
            var query = await _context.Todo.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<TodoGetListItemRAO>>(query);

            return rao;
        }

        public async Task<TodoGetListItemRAO> GetTodoById(int id)
        {
            var query = await _context.Todo.FirstOrDefaultAsync(q => q.TodoId == id);
            var rao = _mapper.Map<TodoGetListItemRAO>(query);

            return rao;
        }

        public async Task<bool> UpdateTodo(TodoUpdateRAO rao)
        {
            var entity = await _context.Todo.SingleOrDefaultAsync(e => e.TodoId == rao.TodoId);

            entity.Title = rao.Title;
            entity.Body = rao.Body;
            entity.IsCompleted = rao.IsCompleted;
            entity.UpdatedOn = rao.UpdatedOn;

            return await _context.SaveChangesAsync() == 1;
        }

        public Task<bool> DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
