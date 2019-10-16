using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoBusinessLayer.DataContract.Todo;
using TodoWebApi.DataContract.Todo;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITodoManager _manager;

        public TodoController(IMapper mapper, ITodoManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodo(TodoCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<TodoCreateDTO>(request);
            dto.CreatedOn = DateTime.Now;
            dto.IsCompleted = false;

            if (await _manager.CreateTodo(dto))
                return StatusCode(201);

            throw new Exception();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetTodos();
            var response = _mapper.Map<IEnumerable<TodoGetListItemResponse>>(dto);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetTodoById(id);
            var response = _mapper.Map<TodoGetListItemResponse>(dto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTodo(TodoUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<TodoUpdateDTO>(request);
            dto.UpdatedOn = DateTime.Now;

            if (await _manager.UpdateTodo(dto))
                return StatusCode(202);

            throw new Exception();
        }
    }
}
