namespace Todo_Cosmos_Db_Test.Server.Services;

public record TodoService(DatabaseContext DatabaseContext) : ITodoService
{
}
