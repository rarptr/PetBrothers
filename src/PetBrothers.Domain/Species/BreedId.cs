using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Species;

public record BreedId : IBaseId
{
    public Guid Value { get; }

    public static BreedId New() => new(Guid.NewGuid());
    public static BreedId Empty() => new(Guid.Empty);
    public static BreedId Create(Guid id) => new(id);

    public static implicit operator BreedId(Guid id) => new BreedId(id);

    public static implicit operator Guid(BreedId BreedId)
        => BreedId?.Value ?? throw new ArgumentNullException(nameof(BreedId));

    private BreedId(Guid value) => Value = value;
}
