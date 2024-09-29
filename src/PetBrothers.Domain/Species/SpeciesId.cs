using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Species;

public record SpeciesId : IBaseId
{
    public Guid Value { get; }

    public static SpeciesId New() => new(Guid.NewGuid());
    public static SpeciesId Empty() => new(Guid.Empty);
    public static SpeciesId Create(Guid id) => new(id);

    public static implicit operator SpeciesId(Guid id) => new SpeciesId(id);

    public static implicit operator Guid(SpeciesId SpeciesId)
        => SpeciesId?.Value ?? throw new ArgumentNullException(nameof(SpeciesId));

    private SpeciesId(Guid value) => Value = value;
}
