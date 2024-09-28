using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record CurrentAddress
{
    public const int MAX_LENGTH = Constants.MAX_MEDIUM_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<CurrentAddress> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(CurrentAddress)} is invalid";

        return new CurrentAddress(value);
    }

    private CurrentAddress() { }

    private CurrentAddress(string value) => Value = value;
}