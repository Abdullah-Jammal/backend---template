using BackendTemplate.Application.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BackendTemplate.Application.Todos;

public sealed class TodoService(IApplicationDbContext dbContext) : ITodoService
{
    public async Task<IReadOnlyList<TodoDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.TodoItems
            .AsNoTracking()
            .Select(todo => new TodoDto(todo.Id, todo.Title, todo.IsCompleted))
            .ToListAsync(cancellationToken);
    }
}
