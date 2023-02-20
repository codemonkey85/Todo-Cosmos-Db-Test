namespace Todo_Cosmos_Db_Test.Server.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

    public DbSet<Todo> Todos { get; set; } = default!;
}
