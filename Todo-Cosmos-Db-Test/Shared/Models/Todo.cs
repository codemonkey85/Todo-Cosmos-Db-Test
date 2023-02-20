namespace Todo_Cosmos_Db_Test.Shared.Models;

public class Todo
{
    public Guid Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime? DueDate { get; set; }
}
