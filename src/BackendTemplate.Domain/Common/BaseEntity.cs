namespace BackendTemplate.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTimeOffset CreatedOnUtc { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? LastModifiedOnUtc { get; set; }
}
