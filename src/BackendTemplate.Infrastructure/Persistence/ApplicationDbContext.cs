using BackendTemplate.Application.Abstractions;
using BackendTemplate.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackendTemplate.Infrastructure.Persistence;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<IdentityUser>(options), IApplicationDbContext
{
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<TodoItem>(entity =>
        {
            entity.HasKey(todo => todo.Id);
            entity.Property(todo => todo.Title)
                .HasMaxLength(250)
                .IsRequired();
        });
    }
}
