using PetBrothers.Domain.Species;

namespace PetBrothers.Domain.Volunteers.Pets;

/// <summary>
/// Тип животного
/// </summary>
public record AnimalType
{
    public SpeciesId SpeciesId { get; }

    public Guid BreedId { get; }

    public static AnimalType Create(SpeciesId speciesId, BreedId breedId)
    {
        return new AnimalType(speciesId, breedId);
    }

    private AnimalType(SpeciesId speciesId, Guid breedId)
    {
        SpeciesId = speciesId;
        BreedId = breedId;
    }
}
