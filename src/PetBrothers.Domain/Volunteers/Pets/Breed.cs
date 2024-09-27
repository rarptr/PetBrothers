using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Breed
{
    public string Value { get; } = string.Empty;

    public static Result<Breed> Create(string value) => new Breed(value);

    private Breed() { }

    private Breed(string value) => Value = value;

}