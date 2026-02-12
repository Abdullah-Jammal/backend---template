namespace BackendTemplate.Application.Todos;

public interface ITodoService
{
    Task<IReadOnlyList<TodoDto>> GetAllAsync(CancellationToken cancellationToken = default);
}
