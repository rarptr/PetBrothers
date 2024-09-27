using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record CurrentAddress
{
    public string Value { get; } = string.Empty;

    public static Result<CurrentAddress> Create(string value) => new CurrentAddress(value);

    private CurrentAddress() { }

    private CurrentAddress(string value) => Value = value;
}