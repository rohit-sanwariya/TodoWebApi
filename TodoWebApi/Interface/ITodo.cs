using TodoWebApi.Model;

namespace TodoWebApi
{
    public interface ITodo
    {
        public Task<List<Todo>> GetTodos();
        public Task<List<Todo>> AddTodo(Todo todo);
    }
}
