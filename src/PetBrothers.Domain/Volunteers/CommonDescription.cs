using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record CommonDescription
{
    public string Value { get; } = string.Empty;

    public static Result<CommonDescription> Create(string value) => new CommonDescription(value);

    private CommonDescription() { }

    private CommonDescription(string value) => Value = value;
}