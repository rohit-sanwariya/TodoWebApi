using Microsoft.AspNetCore.Mvc;
using TodoWebApi.Model;

namespace TodoWebApi.Controllers;

[Route("/api/[controller]")]
public class TodoController  : ControllerBase
{
    private readonly ITodo _todoRepo;
    public TodoController(ITodo todo)
    {
        _todoRepo = todo;
    }
    [HttpGet]
    public async Task<ActionResult<List<Todo>>> GetTodos()
    {
        return Ok(await _todoRepo.GetTodos());
    }

    [HttpPost("Add")]
    public async Task<ActionResult<List<Todo>>> AddTodo(Todo todo)
    {
      return Ok(await _todoRepo.AddTodo(todo));
    }
}