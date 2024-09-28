using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record PhoneNumber
{
    public const int MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<PhoneNumber> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(PhoneNumber)} is invalid";

        return new PhoneNumber(value);
    }

    private PhoneNumber() { }

    private PhoneNumber(string value) => Value = value;
}