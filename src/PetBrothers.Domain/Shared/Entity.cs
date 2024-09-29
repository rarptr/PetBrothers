namespace PetBrothers.Domain.Shared;

public abstract class Entity<TId> where TId : notnull, IBaseId
{
    /// <summary>
    /// Id
    /// </summary>
    public TId Id { get; private set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedDateTime { get; private set; } = DateTime.UtcNow;

    protected Entity(TId id) => Id = id;
}
