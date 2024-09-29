using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record Email
{
    public const int MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<Email> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(Email)} is invalid";

        return new Email(value);
    }

    private Email(string value) => Value = value;
}