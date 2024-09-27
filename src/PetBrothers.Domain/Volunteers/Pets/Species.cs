using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Species
{
    public string Value { get; } = string.Empty;

    public static Result<Species> Create(string value) => new Species(value);

    private Species() { }

    private Species(string value) => Value = value;
}