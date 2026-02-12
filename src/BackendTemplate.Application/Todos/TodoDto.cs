namespace BackendTemplate.Application.Todos;

public sealed record TodoDto(Guid Id, string Title, bool IsCompleted);
