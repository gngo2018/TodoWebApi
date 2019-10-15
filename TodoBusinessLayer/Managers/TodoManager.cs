using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TodoBusinessLayer.DataContract.Todo;
using TodoWebApi.DataContract.Todo;

namespace TodoBusinessLayer.Managers
{
    public class TodoManager : ITodoManager
    {
        private readonly IMapper _mapper;
        private readonly ITodoRepository _repository;

        public TodoManager(IMapper mapper, ITodoRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateTodo(TodoCreateDTO dto)
        {
            var rao = _mapper.Map<TodoCreateRAO>(dto);

            if (await _repository.CreateTodo(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoGetListItemDTO>> GetTodos()
        {
            var rao = await _repository.GetTodos();
            var dto = _mapper.Map<IEnumerable<TodoGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<TodoGetListItemDTO> GetTodoById(int id)
        {
            var rao = await _repository.GetTodoById(id);
            var dto = _mapper.Map<TodoGetListItemDTO>(rao);

            return dto;
        }

        public Task<bool> UpdateTodo(TodoUpdateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
