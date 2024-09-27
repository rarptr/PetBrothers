using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record PhoneNumber
{
    public string Value { get; } = string.Empty;

    public static Result<PhoneNumber> Create(string value) => new PhoneNumber(value);

    private PhoneNumber() { }

    private PhoneNumber(string value) => Value = value;
}