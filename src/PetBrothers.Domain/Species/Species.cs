using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Species;

/// <summary>
/// Вид животного
/// </summary>
public sealed class Species : Entity<SpeciesId>
{
    private readonly List<Breed> _breeds = [];

    /// <summary>
    /// Название
    /// </summary>
    public Name Name { get; private set; } = default!;

    /// <summary>
    /// Домашние животные, закреплённые за волонтёром
    /// </summary>
    public IReadOnlyList<Breed> Breeds => _breeds;

    public static Result<Species> Create(SpeciesId breedId, Name name)
    {
        return new Species(breedId, name);
    }

    public Result AddBreed(Breed breed)
    {
        _breeds.Add(breed);
        return Result.Success();
    }

    private Species() : base(SpeciesId.New()) { }

    private Species(SpeciesId id, Name name) : base(id) => Name = name;
}
