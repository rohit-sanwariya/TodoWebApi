using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TodoWebApi.Data;
using TodoWebApi.Model;

namespace TodoWebApi
{
    public class TodoRepository : ITodo
    {
        readonly private ApplicationDbContext _context;
        public TodoRepository(ApplicationDbContext context)
        {
            _context = context;

        }
       public async Task<List<Todo>> AddTodo(Todo todo)
        {
             _context.Todos.Add(todo);
            Console.WriteLine($"SaveChangesAsync Method Started by ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            await _context.SaveChangesAsync();
            return await GetTodos();
        }

        public async Task<List<Todo>> GetTodos()
        {
            return await _context.Todos.ToListAsync<Todo>();
        }
    }
}
