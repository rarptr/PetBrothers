using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Species;

/// <summary>
/// Порода
/// </summary>
public sealed class Breed : Entity<BreedId>
{
    public Name Name { get; private set; } = default!;

    public Species Species { get; private set; } = default!;

    public static Result<Breed> Create(BreedId breedId, Name name)
    {
        ArgumentNullException.ThrowIfNull(breedId, nameof(breedId));
        ArgumentNullException.ThrowIfNull(name, nameof(name));

        return new Breed(breedId, name);
    }

    private Breed() : base(BreedId.New()) { }
    
    private Breed(BreedId breedId, Name name) : base(breedId) => Name = name;
}
