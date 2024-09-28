using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Species
{
    public const int MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<Species> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(Species)} is invalid";

        return new Species(value);
    }

    private Species() { }

    private Species(string value) => Value = value;
}