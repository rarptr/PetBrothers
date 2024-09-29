using PetBrothers.Domain.Species;

namespace PetBrothers.Domain.Volunteers.Pets;

/// <summary>
/// Тип животного
/// </summary>
public record AnimalType
{
    public SpeciesId SpeciesId { get; }

    public BreedId BreedId { get; }

    public static AnimalType Create(SpeciesId speciesId, BreedId breedId)
    {
        ArgumentNullException.ThrowIfNull(speciesId, nameof(breedId));
        ArgumentNullException.ThrowIfNull(breedId, nameof(breedId));

        return new AnimalType(speciesId, breedId);
    }

    private AnimalType(SpeciesId speciesId, BreedId breedId)
    {
        SpeciesId = speciesId;
        BreedId = breedId;
    }
}
