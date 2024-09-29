using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Breed
{
    public const int MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<Breed> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(Breed)} is invalid";

        return new Breed(value);
    }

    private Breed(string value) => Value = value;

}