using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Colour
{
    public string Value { get; } = string.Empty;

    public static Result<Colour> Create(string value) => new Colour(value);

    public Colour() { }

    private Colour(string value) => Value = value;
}