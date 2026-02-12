using BackendTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendTemplate.Application.Abstractions;

public interface IApplicationDbContext
{
    DbSet<TodoItem> TodoItems { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
