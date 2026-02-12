using BackendTemplate.Domain.Common;

namespace BackendTemplate.Domain.Entities;

public sealed class TodoItem : BaseEntity
{
    public required string Title { get; set; }
    public bool IsCompleted { get; set; }
}
