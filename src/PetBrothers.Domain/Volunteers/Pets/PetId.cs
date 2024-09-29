using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record PetId : IBaseId
{
    public Guid Value { get; }

    public static PetId New() => new(Guid.NewGuid());
    public static PetId Empty() => new(Guid.Empty);
    public static PetId Create(Guid id) => new(id);

    public static implicit operator PetId(Guid id) => new PetId(id);

    public static implicit operator Guid(PetId PetId)
        => PetId?.Value ?? throw new ArgumentNullException(nameof(PetId));

    private PetId(Guid value) => Value = value;
}
