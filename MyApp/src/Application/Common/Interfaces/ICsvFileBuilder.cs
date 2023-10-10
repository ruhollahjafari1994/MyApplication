using MyApp.Application.TodoLists.Queries.ExportTodos;

namespace MyApp.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
