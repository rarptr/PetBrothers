using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Description
{
    public string Value { get; } = string.Empty;

    public static Result<Description> Create(string value) => new Description(value);

    private Description() { }

    private Description(string value) => Value = value;
}