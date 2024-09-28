using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Description
{
    public const int MAX_LENGTH = Constants.MAX_MEDIUM_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<Description> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(Description)} is invalid";

        return new Description(value);
    }

    private Description() { }

    private Description(string value) => Value = value;
}