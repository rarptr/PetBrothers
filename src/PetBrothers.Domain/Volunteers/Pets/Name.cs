using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Name
{
    public string Value { get; } = string.Empty;

    public static Result<Name> Create(string value) => new Name(value);

    private Name() { }

    private Name(string value) => Value = value;
}