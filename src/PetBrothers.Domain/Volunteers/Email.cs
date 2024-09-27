using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record Email
{
    public string Value { get; } = string.Empty;

    public static Result<Email> Create(string value) => new Email(value);

    private Email() { }

    private Email(string value) => Value = value;
}