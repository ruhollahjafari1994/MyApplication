using MyApp.Application.Common.Mappings;
using MyApp.Domain.Entities;

namespace MyApp.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
