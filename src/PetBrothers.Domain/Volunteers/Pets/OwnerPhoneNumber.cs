using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record OwnerPhoneNumber
{
    public const int MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<OwnerPhoneNumber> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(OwnerPhoneNumber)} is invalid";

        return new OwnerPhoneNumber(value);
    }

    private OwnerPhoneNumber() { }

    private OwnerPhoneNumber(string value) => Value = value;
}