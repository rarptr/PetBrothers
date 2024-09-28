using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Name
{
    public const int MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<Name> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(Name)} is invalid";

        return new Name(value);
    }

    private Name(string value) => Value = value;
}