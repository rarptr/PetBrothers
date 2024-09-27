using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record OwnerPhoneNumber
{
    public string Value { get; } = string.Empty;

    public static Result<OwnerPhoneNumber> Create(string value) => new OwnerPhoneNumber(value);

    private OwnerPhoneNumber() { }

    private OwnerPhoneNumber(string value) => Value = value;
}