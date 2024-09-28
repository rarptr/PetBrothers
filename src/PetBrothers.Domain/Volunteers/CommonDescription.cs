using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record CommonDescription
{
    public const int MAX_LENGTH = Constants.MAX_MEDIUM_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<CommonDescription> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(CommonDescription)} is invalid";

        return new CommonDescription(value);
    }

    private CommonDescription() { }

    private CommonDescription(string value) => Value = value;
}