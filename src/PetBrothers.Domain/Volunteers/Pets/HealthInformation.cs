using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record HealthInformation
{
    public const int MAX_LENGTH = Constants.MAX_LARGE_LENGTH;

    public string Value { get; } = string.Empty;

    public static Result<HealthInformation> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            return $"{nameof(HealthInformation)} is invalid";

        return new HealthInformation(value);
    }

    private HealthInformation(string value) => Value = value;
}