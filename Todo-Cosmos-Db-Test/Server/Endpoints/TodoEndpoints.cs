namespace Todo_Cosmos_Db_Test.Server.Endpoints;

public static class TodoEndpoints
{
    private static readonly List<Todo> Todos = new()
    {
        new Todo
        {
            Id = Guid.NewGuid(),
            Title = "Test",
            Description = "Test",
            IsCompleted = false,
            DueDate = DateTime.Now.AddDays(-1),
        },
    };

    public static IEndpointRouteBuilder MapTodoEndpoints(this IEndpointRouteBuilder apiGroup)
    {
        var todosGroup = apiGroup.MapGroup("todos");

        todosGroup.MapGet(string.Empty, GetTodosAsync);
        todosGroup.MapGet("/{todoId:int}", GetTodoAsync);
        todosGroup.MapPost(string.Empty, CreateNewTodoAsync);
        todosGroup.MapPut(string.Empty, UpdateTodoAsync);
        todosGroup.MapDelete("/{todoId:int}", DeleteTodoAsync);

        return apiGroup;
    }

    private static async Task<Ok<List<Todo>>> GetTodosAsync() =>
        TypedResults.Ok(Todos);

    private static async Task<Ok<Todo?>> GetTodoAsync(int todoId) =>
        throw new NotImplementedException();

    private static async Task<Todo> CreateNewTodoAsync(Todo newTodo) =>
        throw new NotImplementedException();

    private static async Task<Todo> UpdateTodoAsync(Todo todo) =>
        throw new NotImplementedException();

    private static async Task<bool> DeleteTodoAsync(int todoId) =>
        throw new NotImplementedException();

}
